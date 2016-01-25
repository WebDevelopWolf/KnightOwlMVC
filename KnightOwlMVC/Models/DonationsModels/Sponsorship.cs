using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using KnightOwlMVC.Models.CustomerModels;

namespace KnightOwlMVC.Models.DonationsModels
{
    public class Sponsorship
    {
        [ScaffoldColumn(false)]
        public int SponsorshipId { get; set; }

        [DisplayName("Animal to sponsor")]
        [Required(ErrorMessage = "Select an animal")]
        public virtual AnimalModels.Animal AnimalId { get; set; }

        [DisplayName("Customer taking sponsorship")]
        [Required(ErrorMessage = "Select a Customer")]
        public virtual Customer CustomerId { get; set; }

        public string Package { get; set; }

        [DataType(DataType.Currency)]
        public decimal Amount { get; set; }

        [DisplayName("Sponsorship Start Date")]
        [Required(ErrorMessage = "Enter a start date for the sponsorship")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DisplayName("Sponsorship Expiry Date")]
        [Required(ErrorMessage = "Enter an expiry date for the sponsorship")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
    }
}