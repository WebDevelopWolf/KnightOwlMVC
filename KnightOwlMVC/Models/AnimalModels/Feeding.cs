namespace KnightOwlMVC.Models.AnimalModels
{
    public class Feeding
    {
        public int FeedingId { get; set; }

        public virtual AnimalModels.Animal AnimalId { get; set; }

        public string Day { get; set; }

        public string Amount { get; set; }

        public string Food { get; set; }
    }
}