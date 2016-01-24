using System;

namespace KnightOwlMVC.Models.AnimalModels
{
    public class Animal
    {
        public int AnimalId { get; set; }

        public string Name {get; set;}

        public virtual Species SpeciesId { get; set; }

        public virtual Enclosure EnclosureId { get; set; }

        public DateTime AquiredDate { get; set; }

        public Byte[] Picture { get; set; }

        public int Age { get; set; }

        public string Notes { get; set; }

        public string Tempriment { get; set; }

        public string ResidentStatus { get; set; }

        public string LicenceNo { get; set; }
    }
}