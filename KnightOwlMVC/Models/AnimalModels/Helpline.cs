using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using KnightOwlMVC.Models.StaffModels;

namespace KnightOwlMVC.Models.AnimalModels
{
    public class Helpline
    {
        [ScaffoldColumn(false)]
        public int HelplineId { get; set; }

        [DisplayName("Callers Name")]
        public string NameOfCaller { get; set; }

        [DisplayName("Callers Location")]
        public string LocationOfCaller { get; set; }

        [DisplayName("Callers Contact Number")]
        [DataType(DataType.PhoneNumber)]
        public int TelephoneOfCaller { get; set; }

        [DataType(DataType.MultilineText)]
        public string Injury { get; set; }

        public virtual RescueCentre RescueCentreId { get; set; }

        [DataType(DataType.MultilineText)]
        public string Outcome { get; set; }

        [DisplayName("Animal")]
        public virtual Animal AnimalId { get; set; }

        [Required(ErrorMessage = "Please record who took the call")]
        [DisplayName("Staff")]
        public virtual Staff StaffId { get; set; }
    }
}