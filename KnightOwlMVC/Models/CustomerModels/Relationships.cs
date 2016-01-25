using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KnightOwlMVC.Models.CustomerModels
{
    public class Relationships
    {
        [ScaffoldColumn(false)]
        public int RelationshipsId { get; set; }

        [DisplayName("Customer Related To")]
        [Required(ErrorMessage = "Select a Customer")]
        public virtual Customer RelatedTo { get; set; }

        [DisplayName("Customer ")]
        [Required(ErrorMessage = "Select a Customer")]
        public virtual Customer CustomerId { get; set; }

        [Required(ErrorMessage = "Select a Relationship")]
        public string Relationship { get; set; }

        public int Probability { get; set; }
    }
}