using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnightOwlMVC.Models.WebModels
{
    public class ApplicationSettings
    {
        public int ApplicationSettingsId { get; set; }

        public string InstitutionName { get; set; }

        public string InstitutionContact { get; set; }

        public string InstitutionOwner { get; set; }

        public bool Mail { get; set; }

        public bool Animal { get; set; }

        public bool Customer { get; set; }

        public bool Donation { get; set; }

        public bool Events { get; set; }

        public bool Marketing { get; set; }

        public bool Staff { get; set; }

        public bool Consumer { get; set; }

        public bool Web { get; set; }

        public string Vet { get; set; }

        public string VetContact { get; set; }
    }
}