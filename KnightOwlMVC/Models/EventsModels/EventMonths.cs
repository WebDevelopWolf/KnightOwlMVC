using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KnightOwlMVC.Models.EventsModels
{
    public class EventMonths
    {
        [ScaffoldColumn(false)]
        public int EventMonthsId { get; set; }

        [DisplayName("Event")]
        [Required(ErrorMessage = "Select an event")]
        public virtual Event EventId { get; set; }

        public bool Jan { get; set; }

        public bool Feb { get; set; }

        public bool Mar { get; set; }

        public bool Apr { get; set; }

        public bool May { get; set; }

        public bool Jun { get; set; }

        public bool Jul { get; set; }

        public bool Aug { get; set; }

        public bool Sep { get; set; }

        public bool Oct { get; set; }

        public bool Nov { get; set; }

        public bool Dec { get; set; }
    }
}