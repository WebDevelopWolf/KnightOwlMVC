using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnightOwlMVC.Models.AnimalModels
{
    public class SubSpecies
    {
        public int SubSpeciesId { get; set; }

        public virtual Species SpeciesId { get; set; }

        public string SubSpeciesName { get; set; }
    }
}