using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KnightOwlMVC.Models.StaffModels
{
    public class StaffMedical
    {
        [ScaffoldColumn(false)]
        public int StaffMedicalId { get; set; }

        [DisplayName("Medical Condition")]
        [Required(ErrorMessage = "Enter a medical condition")]
        public string MedicalCondition { get; set; }

        [DisplayName("Medication")]
        public string Medication { get; set; }

        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }

        [DisplayName("Staff")]
        [Required(ErrorMessage = "Select a staff member")]
        public virtual Staff StaffId { get; set; }
    }
}