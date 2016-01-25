using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KnightOwlMVC.Models.AnimalModels
{
    public class Species
    {
        [ScaffoldColumn(false)]
        public int SpeciesId { get; set; }

        [DisplayName("Species")]
        [Required(ErrorMessage = "Please enter a species")]
        public string AnimalSpecies { get; set; }
    }
}