using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KnightOwlMVC.Models.CustomerModels;

namespace KnightOwlMVC.Models.EventsModels
{
    public class Booking
    {
        public int BookingId { get; set; }

        public virtual Customer CustomerId { get; set; }

        public string TelephoneContact { get; set; }

        public string VoucherType { get; set; }

        public string VoucherCode { get; set; }

        public string AdditionalInfoGiven { get; set; }

        public string Notes { get; set; }

        public virtual Event EventId { get; set; }

        public DateTime Date { get; set; }
    }
}