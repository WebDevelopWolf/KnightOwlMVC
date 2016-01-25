using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using KnightOwlMVC.Models.StaffModels;

namespace KnightOwlMVC.Models.AnimalModels
{
    public class KeeperLog
    {
        [ScaffoldColumn(false)]
        public int KeeperLogId { get; set; }

        [Required(ErrorMessage = "Please record the date and time of the incident")]
        [DataType(DataType.DateTime)]
        [DisplayName("Date and Time of Incident")]
        public DateTime IncidentDateTime { get; set; }

        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }

        [Required(ErrorMessage = "Please select an animal")]
        [DisplayName("Animal")]
        public virtual AnimalModels.Animal AnimalId { get; set; }

        [DisplayName("Staff")]
        public virtual Staff StaffId { get; set; }
    }
}