using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10389916_AAPD7112_POE
{
    class Issue
    {
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public List<string> Attachments { get; set; }

        public Issue()
        {
            Attachments = new List<string>();
        }
    }
}
