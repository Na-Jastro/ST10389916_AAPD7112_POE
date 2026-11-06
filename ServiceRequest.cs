using System;

namespace ST10389916_AAPD7112_POE
{
    public class ServiceRequest
    {
        public string RequestId { get; set; }
        public string Location { get; set; }
        public string Category { get; set; }
        public string Status { get; set; }
        public int Priority { get; set; }
        public int EstimatedDays { get; set; }
        public DateTime SubmittedOn { get; set; }

        public ServiceRequest(string requestId, string location, string category, string status, int priority, int estimatedDays, DateTime submittedOn)
        {
            RequestId = requestId;
            Location = location;
            Category = category;
            Status = status;
            Priority = priority;
            EstimatedDays = estimatedDays;
            SubmittedOn = submittedOn;
        }
    }
}
