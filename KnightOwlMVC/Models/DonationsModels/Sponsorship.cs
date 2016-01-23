using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KnightOwlMVC.Models.CustomerModels;

namespace KnightOwlMVC.Models.DonationsModels
{
    public class Sponsorship
    {
        public int SponsorshipId { get; set; }

        public virtual AnimalModels.Animal AnimalId { get; set; }

        public virtual Customer CustomerId { get; set; }

        public string Package { get; set; }

        public decimal Amount { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}