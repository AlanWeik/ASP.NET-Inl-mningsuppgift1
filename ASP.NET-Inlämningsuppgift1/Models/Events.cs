using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Inlämningsuppgift1.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Place { get; set; }
        public int Date { get; set; }
        public int Spots_Available { get; set; }
        public List<Attendee> Attendees { get; set; }
    }
}
