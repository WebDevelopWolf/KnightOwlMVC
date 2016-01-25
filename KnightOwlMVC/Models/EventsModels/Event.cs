using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnightOwlMVC.Models.EventsModels
{
    public class Event
    {
        public int EventId { get; set; }

        public string Title { get; set; }

        public string Type { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public double Cost { get; set; }

        public int NoPerDay { get; set; }

        public int NoPerSession { get; set; }

        public bool Recurring { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public string Location { get; set; }
    }
}