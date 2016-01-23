using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnightOwlMVC.Models.EventsModels
{
    public class EventDays
    {
        public int EventDaysId { get; set; }

        public virtual Event EventId { get; set; }

        public bool Monday { get; set; }

        public bool Tuesday { get; set; }

        public bool Wednesday { get; set; }

        public bool Thursday { get; set; }

        public bool Friday { get; set; }

        public bool Saturday { get; set; }

        public bool Sunday { get; set; }
    }
}