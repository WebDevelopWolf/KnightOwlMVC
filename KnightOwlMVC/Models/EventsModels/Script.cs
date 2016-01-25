using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KnightOwlMVC.Models.EventsModels
{
    public class Script
    {
        [ScaffoldColumn(false)]
        public int ScriptId { get; set; }

        [DisplayName("Event")]
        [Required(ErrorMessage = "Select an event")]
        public virtual Event EventId { get; set; }

        [DisplayName("Script")]
        [Required(ErrorMessage = "Enter the script for this event")]
        [DataType(DataType.MultilineText)]
        public string EventScript { get; set; }
    }
}