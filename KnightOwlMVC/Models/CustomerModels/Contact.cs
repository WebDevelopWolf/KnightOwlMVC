using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KnightOwlMVC.Models.CustomerModels
{
    public class Contact
    {
        [ScaffoldColumn(false)]
        public int ContactId { get; set; }

        [DisplayName("Contact Method")]
        [Required(ErrorMessage = "Please enter a method")]
        public string Method { get; set; }

        [DisplayName("Contact Value")]
        [Required(ErrorMessage = "Please enter a phone number, email address etc.")]
        public string ContactSpecific { get; set; }

        [DisplayName("Tick this box if the customer wishes to not be contacted via this method")]
        [Required(ErrorMessage = "Please select an option")]
        public bool DoNotContact { get; set; }

        [DisplayName("Customer")]
        [Required(ErrorMessage = "Please select a customer")]
        public virtual Customer CustomerId { get; set; }
    }
}