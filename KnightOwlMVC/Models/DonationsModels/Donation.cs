using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using KnightOwlMVC.Models.CustomerModels;

namespace KnightOwlMVC.Models.DonationsModels
{
    public class Donation
    {
        [ScaffoldColumn(false)]
        public int DonationId { get; set; }

        [DisplayName("Customer")]
        [Required(ErrorMessage = "Select a Customer")]
        public virtual Customer CustomerId { get; set; }

        [DisplayName("Donation Value")]
        [Required(ErrorMessage = "Enter the value of the donation")]
        [DataType(DataType.Currency)]
        public double Value { get; set; }

        [DisplayName("Date of Donation")]
        [Required(ErrorMessage = "Enter date of donation")]
        public DateTime Date { get; set; }

        [DisplayName("Funds Reserved For")]
        public string FundsTowards { get; set; }

        [DisplayName("Items Donated")]
        [DataType(DataType.MultilineText)]
        public string ItemsDonated { get; set; }

        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }
    }
}