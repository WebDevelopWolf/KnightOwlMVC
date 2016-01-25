namespace KnightOwlMVC.Models.CustomerModels
{
    public class Relationships
    {
        public int RelationshipsId { get; set; }

        public virtual Customer RelatedTo { get; set; }

        public virtual Customer CustomerId { get; set; }

        public string Relationship { get; set; }

        public int Probability { get; set; }
    }
}