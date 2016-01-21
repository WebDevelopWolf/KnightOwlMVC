using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnightOwlMVC.Models.Animal
{
    public class Animal
    {
        public int AnimalId { get; set; }

        public string Name {get; set;}

        public string Species { get; set; }

        public string SubSpecies { get; set; }

        public DateTime AquiredDate { get; set; }

        public Byte[] Picture { get; set; }

        public string Enclosure { get; set; }

        public int Age { get; set; }

        public string Notes { get; set; }

        public string Tempriment { get; set; }

        public string ResidentStatus { get; set; }

        public string LicenceNo { get; set; }
    }
}