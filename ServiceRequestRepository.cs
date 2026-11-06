using System;
using System.Collections.Generic;
using System.Linq;

namespace ST10389916_AAPD7112_POE
{
    public static class ServiceRequestRepository
    {
        private static readonly List<ServiceRequest> _requests;
        private static readonly RequestIdBst _requestIdBst;
        private static readonly PriorityAvlTree _priorityAvl;
        private static readonly EtaMinHeap _etaMinHeap;
        private static readonly BasicServiceTree _serviceTree;
        private static readonly ZoneGraph _zoneGraph;

        static ServiceRequestRepository()
        {
            DateTime today = DateTime.Today;

            _requests = new List<ServiceRequest>
            {
                new ServiceRequest("SR-1001", "Ward 1 - Main Road", "Roads", "In Progress", 5, 2, today.AddDays(-4)),
                new ServiceRequest("SR-1002", "Ward 2 - River Street", "Sanitation", "Submitted", 3, 5, today.AddDays(-2)),
                new ServiceRequest("SR-1003", "Ward 3 - Hilltop", "Utilities", "Resolved", 4, 1, today.AddDays(-7)),
                new ServiceRequest("SR-1004", "Ward 1 - Market Square", "Roads", "Submitted", 2, 7, today.AddDays(-1)),
                new ServiceRequest("SR-1005", "Ward 4 - School Zone", "Utilities", "In Progress", 5, 3, today.AddDays(-3)),
                new ServiceRequest("SR-1006", "Ward 5 - Bus Depot", "Sanitation", "Escalated", 4, 2, today.AddDays(-5)),
                new ServiceRequest("SR-1007", "Ward 2 - Community Hall", "Roads", "Submitted", 1, 9, today),
                new ServiceRequest("SR-1008", "Ward 6 - Clinic Road", "Utilities", "In Progress", 3, 4, today.AddDays(-2))
            };

            _requestIdBst = new RequestIdBst();
            _priorityAvl = new PriorityAvlTree();
            _etaMinHeap = new EtaMinHeap();
            _serviceTree = new BasicServiceTree("Service Requests");
            _zoneGraph = new ZoneGraph();

            BuildIndexes();
            BuildGraph();
        }

        private static void BuildIndexes()
        {
            foreach (var request in _requests)
            {
                _requestIdBst.Insert(request);
                _priorityAvl.Insert(request);
                _etaMinHeap.Insert(request);
            }

            var grouped = _requests.GroupBy(r => r.Category, StringComparer.OrdinalIgnoreCase);
            foreach (var group in grouped)
            {
                _serviceTree.AddCategoryWithRequests(group.Key, group);
            }
        }

        private static void BuildGraph()
        {
            _zoneGraph.AddEdge("Ward 1", "Ward 2", 4);
            _zoneGraph.AddEdge("Ward 1", "Ward 3", 3);
            _zoneGraph.AddEdge("Ward 2", "Ward 4", 6);
            _zoneGraph.AddEdge("Ward 3", "Ward 4", 5);
            _zoneGraph.AddEdge("Ward 3", "Ward 5", 7);
            _zoneGraph.AddEdge("Ward 4", "Ward 6", 2);
            _zoneGraph.AddEdge("Ward 5", "Ward 6", 1);
        }

        public static List<ServiceRequest> GetAllRequests()
        {
            return _requests.OrderByDescending(r => r.SubmittedOn).ToList();
        }

        public static ServiceRequest FindById(string requestId)
        {
            if (string.IsNullOrWhiteSpace(requestId)) return null;
            return _requestIdBst.Find(requestId.Trim());
        }

        public static List<ServiceRequest> GetRequestsByPriority()
        {
            return _priorityAvl.GetDescendingPriority();
        }

        public static List<ServiceRequest> GetRequestsByEstimatedResolution()
        {
            return _etaMinHeap.CloneAndDrainOrdered();
        }

        public static List<string> GetCategoryTreeLines()
        {
            return _serviceTree.Flatten();
        }

        public static List<string> GetZoneTraversalFrom(string startZone)
        {
            return _zoneGraph.Bfs(startZone);
        }

        public static int GetMinimumNetworkCost(string startZone)
        {
            return _zoneGraph.PrimMinimumSpanningTreeCost(startZone);
        }
    }
}
