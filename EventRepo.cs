using System;
using System.Collections.Generic;
using System.Linq;

namespace ST10389916_AAPD7112_POE
{
    public class Event
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public DateTime EventDate { get; set; }
        public string Description { get; set; }

        public Event(string title, string category, DateTime eventDate, string description)
        {
            Title = title;
            Category = category;
            EventDate = eventDate;
            Description = description;
        }
    }

    public static class EventRepository
    {
        private static List<Event> _events;
        private static HashSet<string> _categories;
        private static SortedSet<DateTime> _dates;
        private static Dictionary<string, List<Event>> _eventsByCategory;
        private static SortedDictionary<DateTime, List<Event>> _eventsByDate;

        static EventRepository()
        {
            _events = new List<Event>
            {
                new Event("Farmers Market", "Market", new DateTime(2025, 10, 20), "Local farmers selling fresh produce."),
                new Event("Community Clean-Up", "Volunteer", new DateTime(2025, 10, 22), "Help clean up the neighborhood park."),
                new Event("Art Exhibition", "Arts & Culture", new DateTime(2025, 10, 25), "Local artists showcase their work."),
                new Event("Soccer Tournament", "Sports", new DateTime(2025, 11, 1), "Annual community soccer competition."),
                new Event("Book Club Meeting", "Education", new DateTime(2025, 10, 28), "Discussion on the latest bestseller."),
                new Event("Night Market", "Market", new DateTime(2025, 10, 20), "Evening event with food stalls and crafts."),
                new Event("Charity Fun Run", "Sports", new DateTime(2025, 11, 1), "Fundraiser for local shelters."),
                new Event("Coding Workshop", "Education", new DateTime(2025, 10, 28), "Beginner-friendly programming session."),
                new Event("Park Tree Planting", "Volunteer", new DateTime(2025, 10, 22), "Join us to plant trees in the community park."),
                new Event("Street Art Festival", "Arts & Culture", new DateTime(2025, 10, 25), "Murals, music, and local artists performing live."),
                new Event("Food Fair", "Market", new DateTime(2025, 11, 5), "Taste dishes from around the world."),
                new Event("Community Blood Drive", "Volunteer", new DateTime(2025, 11, 5), "Donate blood to save lives."),
                new Event("Science Talk Series", "Education", new DateTime(2025, 11, 10), "Lecture by local scientists on sustainability."),
                new Event("Local Band Night", "Arts & Culture", new DateTime(2025, 11, 10), "Showcasing up-and-coming local bands.")
            };

            _categories = new HashSet<string>(_events.Select(e => e.Category), StringComparer.OrdinalIgnoreCase);
            _dates = new SortedSet<DateTime>(_events.Select(e => e.EventDate));

            _eventsByCategory = _events
                .GroupBy(e => e.Category, StringComparer.OrdinalIgnoreCase)
                .ToDictionary(g => g.Key, g => g.ToList(), StringComparer.OrdinalIgnoreCase);

            _eventsByDate = new SortedDictionary<DateTime, List<Event>>(
                _events.GroupBy(e => e.EventDate)
                       .ToDictionary(g => g.Key, g => g.ToList())
            );
        }

        public static List<Event> GetAllEvents() => new List<Event>(_events);

        public static List<Event> GetEventsByCategory(string category) =>
            _eventsByCategory.TryGetValue(category, out var events) ? events : new List<Event>();

        public static List<Event> GetEventsByDate(DateTime date) =>
            _eventsByDate.TryGetValue(date, out var events) ? events : new List<Event>();

        public static List<Event> GetUpcomingEvents()
        {
            DateTime today = DateTime.Today;
            return _events.FindAll(e => e.EventDate >= today);
        }

        public static HashSet<string> GetUniqueCategories() =>
            new HashSet<string>(_categories, StringComparer.OrdinalIgnoreCase);

        public static SortedSet<DateTime> GetUniqueDates() => new SortedSet<DateTime>(_dates);

        public static void AddEvent(Event newEvent)
        {
            _events.Add(newEvent);

            if (!_categories.Contains(newEvent.Category))
                _categories.Add(newEvent.Category);

            _dates.Add(newEvent.EventDate);

            if (!_eventsByCategory.ContainsKey(newEvent.Category))
                _eventsByCategory[newEvent.Category] = new List<Event>();
            _eventsByCategory[newEvent.Category].Add(newEvent);

            if (!_eventsByDate.ContainsKey(newEvent.EventDate))
                _eventsByDate[newEvent.EventDate] = new List<Event>();
            _eventsByDate[newEvent.EventDate].Add(newEvent);
        }

        public static void RemoveEvent(Event eventToRemove)
        {
            if (!_events.Remove(eventToRemove)) return;

            if (_eventsByCategory.ContainsKey(eventToRemove.Category))
            {
                _eventsByCategory[eventToRemove.Category].Remove(eventToRemove);
                if (_eventsByCategory[eventToRemove.Category].Count == 0)
                {
                    _eventsByCategory.Remove(eventToRemove.Category);
                    _categories.Remove(eventToRemove.Category);
                }
            }

            if (_eventsByDate.ContainsKey(eventToRemove.EventDate))
            {
                _eventsByDate[eventToRemove.EventDate].Remove(eventToRemove);
                if (_eventsByDate[eventToRemove.EventDate].Count == 0)
                {
                    _eventsByDate.Remove(eventToRemove.EventDate);
                    _dates.Remove(eventToRemove.EventDate);
                }
            }
        }

        public static void Clear()
        {
            _events.Clear();
            _categories.Clear();
            _dates.Clear();
            _eventsByCategory.Clear();
            _eventsByDate.Clear();
        }
    }
}
