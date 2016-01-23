using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnightOwlMVC.Models.EventsModels
{
    public class Script
    {
        public int ScriptId { get; set; }

        public virtual Event EventId { get; set; }

        public string EventScript { get; set; }
    }
}