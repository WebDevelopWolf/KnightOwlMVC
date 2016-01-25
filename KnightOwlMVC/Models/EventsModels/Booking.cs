using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using KnightOwlMVC.Models.CustomerModels;

namespace KnightOwlMVC.Models.EventsModels
{
    public class Booking
    {
        [ScaffoldColumn(false)]
        public int BookingId { get; set; }

        [DisplayName("Customer")]
        [Required(ErrorMessage = "Select a Customer")]
        public virtual Customer CustomerId { get; set; }

        [DisplayName("Booking Contact Number")]
        [Required(ErrorMessage = "Enter a contact number")]
        [DataType(DataType.PhoneNumber)]
        public string TelephoneContact { get; set; }

        [DisplayName("Voucher Type")]
        [Required(ErrorMessage = "Select a voucher type")]
        public string VoucherType { get; set; }

        [DisplayName("Voucher Code")]
        [Required(ErrorMessage = "Enter a voucher code (voucher code is required to confirm booking)")]
        public string VoucherCode { get; set; }

        [DataType(DataType.MultilineText)]
        [DisplayName("Additional Information Given to Customer")]
        public string AdditionalInfoGiven { get; set; }

        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }

        [DisplayName("Event to Book")]
        [Required(ErrorMessage = "Select an Event")]
        public virtual Event EventId { get; set; }

        [DisplayName("Event Date")]
        [Required(ErrorMessage = "Select a date")]
        public DateTime Date { get; set; }
    }
}