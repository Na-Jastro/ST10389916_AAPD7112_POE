using System;
using System.Collections.Generic;

namespace ST10389916_AAPD7112_POE
{
    public class BasicTreeNode<T>
    {
        public T Value { get; private set; }
        public List<BasicTreeNode<T>> Children { get; private set; }

        public BasicTreeNode(T value)
        {
            Value = value;
            Children = new List<BasicTreeNode<T>>();
        }
    }

    public class BasicServiceTree
    {
        public BasicTreeNode<string> Root { get; private set; }

        public BasicServiceTree(string rootName)
        {
            Root = new BasicTreeNode<string>(rootName);
        }

        public void AddCategoryWithRequests(string category, IEnumerable<ServiceRequest> requests)
        {
            var categoryNode = new BasicTreeNode<string>(category);
            Root.Children.Add(categoryNode);

            foreach (var request in requests)
            {
                categoryNode.Children.Add(new BasicTreeNode<string>(request.RequestId + " - " + request.Status));
            }
        }

        public List<string> Flatten()
        {
            var output = new List<string>();
            Traverse(Root, output, 0);
            return output;
        }

        private static void Traverse(BasicTreeNode<string> node, List<string> output, int level)
        {
            output.Add(new string(' ', level * 2) + node.Value);
            foreach (var child in node.Children)
            {
                Traverse(child, output, level + 1);
            }
        }
    }

    public class RequestIdBst
    {
        private class Node
        {
            public ServiceRequest Value;
            public Node Left;
            public Node Right;

            public Node(ServiceRequest value)
            {
                Value = value;
            }
        }

        private Node _root;

        public void Insert(ServiceRequest request)
        {
            _root = Insert(_root, request);
        }

        private static Node Insert(Node node, ServiceRequest request)
        {
            if (node == null) return new Node(request);

            int compare = string.Compare(request.RequestId, node.Value.RequestId, StringComparison.OrdinalIgnoreCase);
            if (compare < 0)
                node.Left = Insert(node.Left, request);
            else if (compare > 0)
                node.Right = Insert(node.Right, request);
            else
                node.Value = request;

            return node;
        }

        public ServiceRequest Find(string requestId)
        {
            var current = _root;
            while (current != null)
            {
                int compare = string.Compare(requestId, current.Value.RequestId, StringComparison.OrdinalIgnoreCase);
                if (compare == 0) return current.Value;
                current = compare < 0 ? current.Left : current.Right;
            }
            return null;
        }

        public List<ServiceRequest> InOrder()
        {
            var result = new List<ServiceRequest>();
            InOrder(_root, result);
            return result;
        }

        private static void InOrder(Node node, List<ServiceRequest> result)
        {
            if (node == null) return;
            InOrder(node.Left, result);
            result.Add(node.Value);
            InOrder(node.Right, result);
        }
    }

    public class PriorityAvlTree
    {
        private class Node
        {
            public int Key;
            public List<ServiceRequest> Requests;
            public int Height;
            public Node Left;
            public Node Right;

            public Node(int key, ServiceRequest request)
            {
                Key = key;
                Requests = new List<ServiceRequest> { request };
                Height = 1;
            }
        }

        private Node _root;

        public void Insert(ServiceRequest request)
        {
            _root = Insert(_root, request.Priority, request);
        }

        private static int Height(Node node)
        {
            return node == null ? 0 : node.Height;
        }

        private static int Balance(Node node)
        {
            return node == null ? 0 : Height(node.Left) - Height(node.Right);
        }

        private static Node RotateRight(Node y)
        {
            Node x = y.Left;
            Node t2 = x.Right;

            x.Right = y;
            y.Left = t2;

            y.Height = Math.Max(Height(y.Left), Height(y.Right)) + 1;
            x.Height = Math.Max(Height(x.Left), Height(x.Right)) + 1;

            return x;
        }

        private static Node RotateLeft(Node x)
        {
            Node y = x.Right;
            Node t2 = y.Left;

            y.Left = x;
            x.Right = t2;

            x.Height = Math.Max(Height(x.Left), Height(x.Right)) + 1;
            y.Height = Math.Max(Height(y.Left), Height(y.Right)) + 1;

            return y;
        }

        private static Node Insert(Node node, int key, ServiceRequest request)
        {
            if (node == null) return new Node(key, request);

            if (key < node.Key)
                node.Left = Insert(node.Left, key, request);
            else if (key > node.Key)
                node.Right = Insert(node.Right, key, request);
            else
            {
                node.Requests.Add(request);
                return node;
            }

            node.Height = 1 + Math.Max(Height(node.Left), Height(node.Right));
            int balance = Balance(node);

            if (balance > 1 && key < node.Left.Key)
                return RotateRight(node);

            if (balance < -1 && key > node.Right.Key)
                return RotateLeft(node);

            if (balance > 1 && key > node.Left.Key)
            {
                node.Left = RotateLeft(node.Left);
                return RotateRight(node);
            }

            if (balance < -1 && key < node.Right.Key)
            {
                node.Right = RotateRight(node.Right);
                return RotateLeft(node);
            }

            return node;
        }

        public List<ServiceRequest> GetDescendingPriority()
        {
            var result = new List<ServiceRequest>();
            TraverseDescending(_root, result);
            return result;
        }

        private static void TraverseDescending(Node node, List<ServiceRequest> result)
        {
            if (node == null) return;
            TraverseDescending(node.Right, result);
            result.AddRange(node.Requests);
            TraverseDescending(node.Left, result);
        }
    }

    public class EtaMinHeap
    {
        private readonly List<ServiceRequest> _heap = new List<ServiceRequest>();

        public void Insert(ServiceRequest request)
        {
            _heap.Add(request);
            HeapifyUp(_heap.Count - 1);
        }

        public ServiceRequest ExtractMin()
        {
            if (_heap.Count == 0) return null;

            var min = _heap[0];
            var last = _heap[_heap.Count - 1];
            _heap.RemoveAt(_heap.Count - 1);

            if (_heap.Count > 0)
            {
                _heap[0] = last;
                HeapifyDown(0);
            }

            return min;
        }

        public List<ServiceRequest> CloneAndDrainOrdered()
        {
            var copy = new EtaMinHeap();
            foreach (var request in _heap)
            {
                copy.Insert(request);
            }

            var result = new List<ServiceRequest>();
            ServiceRequest next;
            while ((next = copy.ExtractMin()) != null)
            {
                result.Add(next);
            }

            return result;
        }

        private void HeapifyUp(int index)
        {
            while (index > 0)
            {
                int parent = (index - 1) / 2;
                if (_heap[parent].EstimatedDays <= _heap[index].EstimatedDays)
                    break;

                Swap(parent, index);
                index = parent;
            }
        }

        private void HeapifyDown(int index)
        {
            while (true)
            {
                int left = index * 2 + 1;
                int right = index * 2 + 2;
                int smallest = index;

                if (left < _heap.Count && _heap[left].EstimatedDays < _heap[smallest].EstimatedDays)
                    smallest = left;

                if (right < _heap.Count && _heap[right].EstimatedDays < _heap[smallest].EstimatedDays)
                    smallest = right;

                if (smallest == index)
                    break;

                Swap(index, smallest);
                index = smallest;
            }
        }

        private void Swap(int a, int b)
        {
            var temp = _heap[a];
            _heap[a] = _heap[b];
            _heap[b] = temp;
        }
    }

    public class ZoneGraph
    {
        private class WeightedEdge
        {
            public string To;
            public int Weight;

            public WeightedEdge(string to, int weight)
            {
                To = to;
                Weight = weight;
            }
        }

        private readonly Dictionary<string, List<WeightedEdge>> _adjacency = new Dictionary<string, List<WeightedEdge>>(StringComparer.OrdinalIgnoreCase);

        public void AddEdge(string from, string to, int weight)
        {
            if (!_adjacency.ContainsKey(from)) _adjacency[from] = new List<WeightedEdge>();
            if (!_adjacency.ContainsKey(to)) _adjacency[to] = new List<WeightedEdge>();

            _adjacency[from].Add(new WeightedEdge(to, weight));
            _adjacency[to].Add(new WeightedEdge(from, weight));
        }

        public List<string> Bfs(string start)
        {
            var output = new List<string>();
            if (!_adjacency.ContainsKey(start)) return output;

            var visited = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            var queue = new Queue<string>();
            queue.Enqueue(start);
            visited.Add(start);

            while (queue.Count > 0)
            {
                string node = queue.Dequeue();
                output.Add(node);

                foreach (var edge in _adjacency[node])
                {
                    if (visited.Add(edge.To))
                    {
                        queue.Enqueue(edge.To);
                    }
                }
            }

            return output;
        }

        public int PrimMinimumSpanningTreeCost(string start)
        {
            if (!_adjacency.ContainsKey(start)) return 0;

            var visited = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            visited.Add(start);

            int totalCost = 0;

            while (visited.Count < _adjacency.Count)
            {
                string bestTo = null;
                int bestWeight = int.MaxValue;

                foreach (var from in visited)
                {
                    foreach (var edge in _adjacency[from])
                    {
                        if (visited.Contains(edge.To)) continue;
                        if (edge.Weight < bestWeight)
                        {
                            bestWeight = edge.Weight;
                            bestTo = edge.To;
                        }
                    }
                }

                if (bestTo == null)
                    break;

                visited.Add(bestTo);
                totalCost += bestWeight;
            }

            return totalCost;
        }
    }
}
