using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using KnightOwlMVC.Models.AnimalModels;

namespace KnightOwlMVC.Models
{
    public class KnightOwlContextInitialiser : DropCreateDatabaseAlways<KnightOwlContext>
    {
        protected override void Seed(KnightOwlContext context)
        {
            context.Animals.Add(
                new Animal()
                {
                    Name = "Alfie",
                    Age = 3,
                    AquiredDate = DateTime.Now,
                    EnclosureId = context.Enclosures.Add(new Enclosure() {EnclosureName = "Skunk House", Location = "Zone 1"}),
                    LicenceNo = "12345",
                    Notes = "Skunks iz cool",
                    ResidentStatus = "Resident",
                    SpeciesId = context.Specieses.Add(new Species() {AnimalSpecies = "Skunk"})
                });
            context.SaveChanges();
        }
    }
}