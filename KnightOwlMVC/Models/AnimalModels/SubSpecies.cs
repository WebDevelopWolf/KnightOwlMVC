using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KnightOwlMVC.Models.AnimalModels
{
    public class SubSpecies
    {
        [ScaffoldColumn(false)]
        public int SubSpeciesId { get; set; }

        [DisplayName("Species")]
        [Required(ErrorMessage = "Please select a species")]
        public virtual Species SpeciesId { get; set; }

        [DisplayName("Sub-Species")]
        [Required(ErrorMessage = "Please enter a sub-species")]
        public string SubSpeciesName { get; set; }
    }
}