using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnightOwlMVC.Models.DonationsModels
{
    public class Grant
    {
        public int GrantId { get; set; }

        public string Title { get; set; }

        public string AwardingBody { get; set; }

        public double Amount { get; set; }

        public string Status { get; set; }

        public string EvidenceSupplied { get; set; }

        public bool Granted { get; set; }
    }
}