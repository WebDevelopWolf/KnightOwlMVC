using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KnightOwlMVC.Models.AnimalModels
{
    public class Feeding
    {
        [ScaffoldColumn(false)]
        public int FeedingId { get; set; }

        [Required(ErrorMessage = "Please pick an animal")]
        [DisplayName("Animal")]
        public virtual AnimalModels.Animal AnimalId { get; set; }

        [Required(ErrorMessage = "We need to know the day the animal is fed on")]
        [DisplayName("Day Feed Given")]
        public string Day { get; set; }

        [Required(ErrorMessage = "How much does the animal eat today?")]
        [DisplayName("Amount to Give")]
        public string Amount { get; set; }

        [Required(ErrorMessage = "What does the animal eat today?")]
        [DisplayName("Food to give")]
        public string Food { get; set; }
    }
}