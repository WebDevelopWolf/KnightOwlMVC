using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace KnightOwlMVC.Models.AnimalModels
{
    public class Animal
    {
        [ScaffoldColumn(false)]
        public int AnimalId { get; set; }

        [Required(ErrorMessage = "Animal must have a name")]
        public string Name {get; set;}

        [Required(ErrorMessage = "Please select a species")]
        public virtual Species SpeciesId { get; set; }

        [Required(ErrorMessage = "Please select an enclosure")]
        public virtual Enclosure EnclosureId { get; set; }

        [Required(ErrorMessage = "Date must be entered, if this cannot be exact then enter the closest possible date")]
        [DisplayName("Date Aquired")]
        public DateTime AquiredDate { get; set; }

        public Byte[] Picture { get; set; }

        public int Age { get; set; }
        
        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }

        [Required(ErrorMessage = "Animal must have a tempriment")]
        public string Tempriment { get; set; }

        [Required(ErrorMessage = "Please enter the Resident's status")]
        [DisplayName("Residency Status")]
        public string ResidentStatus { get; set; }

        [DisplayName("Licence Number")]
        public string LicenceNo { get; set; }
    }

}