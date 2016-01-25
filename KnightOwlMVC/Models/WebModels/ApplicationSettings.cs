using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KnightOwlMVC.Models.WebModels
{
    public class ApplicationSettings
    {
        [ScaffoldColumn(false)]
        public int ApplicationSettingsId { get; set; }

        [DisplayName("Centre Name")]
        [Required(ErrorMessage = "Enter a centre name")]
        public string InstitutionName { get; set; }

        [DisplayName("Centre Contact")]
        [Required(ErrorMessage = "Enter a contact for the centre")]
        public string InstitutionContact { get; set; }

        [DisplayName("Centre Owner")]
        [Required(ErrorMessage = "Enter the centre owner")]
        public string InstitutionOwner { get; set; }

        [ScaffoldColumn(false)]
        public bool Mail { get; set; }

        [ScaffoldColumn(false)]
        public bool Animal { get; set; }

        [ScaffoldColumn(false)]
        public bool Customer { get; set; }

        [ScaffoldColumn(false)]
        public bool Donation { get; set; }

        [ScaffoldColumn(false)]
        public bool Events { get; set; }

        [ScaffoldColumn(false)]
        public bool Marketing { get; set; }

        [ScaffoldColumn(false)]
        public bool Staff { get; set; }

        [ScaffoldColumn(false)]
        public bool Consumer { get; set; }

        [ScaffoldColumn(false)]
        public bool Web { get; set; }

        [Required(ErrorMessage = "Enter the centre's Vet Name")]
        public string Vet { get; set; }

        [DisplayName("Vet Contact")]
        [Required(ErrorMessage = "Enter the centre's vet contact")]
        public string VetContact { get; set; }
    }
}