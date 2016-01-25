using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KnightOwlMVC.Models.DonationsModels
{
    public class Grant
    {
        [ScaffoldColumn(false)]
        public int GrantId { get; set; }

        [Required(ErrorMessage = "Please enter a grant title")]
        public string Title { get; set; }

        [DisplayName("Awarding Body")]
        public string AwardingBody { get; set; }

        [DisplayName("Grant Amount (if awarded)")]
        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Enter amount applied for")]
        public double Amount { get; set; }

        public string Status { get; set; }

        [DisplayName("Evidence Submitted")]
        [DataType(DataType.MultilineText)]
        public string EvidenceSupplied { get; set; }

        [DisplayName("Grant awarded?")]
        public bool Granted { get; set; }
    }
}