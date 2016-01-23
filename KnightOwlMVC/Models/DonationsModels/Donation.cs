using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KnightOwlMVC.Models.CustomerModels;

namespace KnightOwlMVC.Models.DonationsModels
{
    public class Donation
    {
        public int DonationId { get; set; }

        public virtual Customer CustomerId { get; set; }

        public double Value { get; set; }

        public DateTime Date { get; set; }

        public string FundsTowards { get; set; }

        public string ItemsDonated { get; set; }

        public string Notes { get; set; }
    }
}