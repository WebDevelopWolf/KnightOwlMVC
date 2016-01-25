using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KnightOwlMVC.Models.EventsModels
{
    public class Event
    {
        [ScaffoldColumn(false)]
        public int EventId { get; set; }

        [Required(ErrorMessage = "Enter an event title")]
        public string Title { get; set; }

        [DisplayName("Event Type")]
        [Required(ErrorMessage = "Eg. Experience, Talk etc.")]
        public string Type { get; set; }

        [Required(ErrorMessage = "Enter a description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Enter a price")]
        [DataType(DataType.Currency)]
        public double Price { get; set; }

        [Required(ErrorMessage = "Enter a cost")]
        [DataType(DataType.Currency)]
        public double Cost { get; set; }

        [DisplayName("Number of Events that can run per day")]
        [Required(ErrorMessage = "Enter the number of events that can run in a day")]
        public int NoPerDay { get; set; }

        [DisplayName("Number of customers per session")]
        [Required(ErrorMessage = "Enter the number of customers that can be on one experience")]
        public int NoPerSession { get; set; }

        [DisplayName("Recurring Event?")]
        public bool Recurring { get; set; }

        [DisplayName("Event Start Time")]
        [Required(ErrorMessage = "Enter the start time of the event")]
        [DataType(DataType.Time)]
        public DateTime StartTime { get; set; }

        [DisplayName("Event Expected End Time")]
        [Required(ErrorMessage = "Enter the expected end time of the event")]
        [DataType(DataType.Time)]
        public DateTime EndTime { get; set; }

        [DisplayName("Event Location")]
        [Required(ErrorMessage = "Enter the location of the event")]
        public string Location { get; set; }
    }
}