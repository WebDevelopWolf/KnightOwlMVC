using System;

namespace KnightOwlMVC.Models.CustomerModels
{
    public class Sponsorship
    {
        public int SponsorshipId { get; set; }

        public virtual AnimalModels.Animal AnimalId { get; set; }

        public string Package { get; set; }

        public decimal Amount { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}