namespace KnightOwlMVC.Models.CustomerModels
{
    public class Contact
    {
        public int ContactId { get; set; }

        public string Method { get; set; }

        public string ContactSpecific { get; set; }

        public bool DoNotContact { get; set; }

        public virtual Customer CustomerId { get; set; }
    }
}