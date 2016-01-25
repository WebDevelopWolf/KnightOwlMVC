using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KnightOwlMVC.Models.AnimalModels
{
    public class Enclosure
    {
        [ScaffoldColumn(false)]
        public int EnclosureId { get; set; }

        [Required(ErrorMessage = "Enclosure must have a name")]
        [DisplayName("Enclosure Name")]
        public string EnclosureName { get; set; }

        [Required(ErrorMessage = "Enclosure must have a location")]
        [DisplayName("Enclosure Location")]
        public string Location { get; set; }
    }
}