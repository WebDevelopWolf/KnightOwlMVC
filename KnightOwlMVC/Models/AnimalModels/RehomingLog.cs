using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Configuration;
using KnightOwlMVC.Models.CustomerModels;

namespace KnightOwlMVC.Models.AnimalModels
{
    public class RehomingLog
    {
        [ScaffoldColumn(false)]
        public int RehomingLogId { get; set; }

        [DisplayName("Rehoming From")]
        [Required(ErrorMessage = "Please state where the animal came from")]
        public virtual Customer RehomingFrom { get; set; }

        [DisplayName("Date of Rehoming")]
        [DataType(DataType.Date)]
        public DateTime RemhomingDate { get; set; }

        [DisplayName("Customer Rehoming Animal")]
        public virtual CustomError RehomingTo { get; set; }

        public string Notes { get; set; }

        [DisplayName("Animal")]
        [Required(ErrorMessage = "Please select an animal")]
        public virtual AnimalModels.Animal AnimalId { get; set; }
    }
}