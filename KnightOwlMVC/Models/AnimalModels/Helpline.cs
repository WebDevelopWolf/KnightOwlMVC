using KnightOwlMVC.Models.StaffModels;

namespace KnightOwlMVC.Models.AnimalModels
{
    public class Helpline
    {
        public int HelplineId { get; set; }

        public string NameOfCaller { get; set; }

        public string LocationOfCaller { get; set; }

        public int TelephoneOfCaller { get; set; }

        public string Injury { get; set; }

        public virtual RescueCentre RescueCentreId { get; set; }

        public string Outcome { get; set; }

        public virtual Animal AnimalId { get; set; }

        public virtual Staff StaffId { get; set; }
    }
}