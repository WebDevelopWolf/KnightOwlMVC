using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KnightOwlMVC.Models.EventsModels
{
    public class EventDays
    {
        [ScaffoldColumn(false)]
        public int EventDaysId { get; set; }

        [DisplayName("Event")]
        [Required(ErrorMessage = "Select an event")]
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