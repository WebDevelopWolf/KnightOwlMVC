using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KnightOwlMVC.Models.AnimalModels
{
    public class Medical : IValidatableObject
    {
        [ScaffoldColumn(false)]
        public int MedicalId { get; set; }

        [Required(ErrorMessage = "Please record the treatment date")]
        [DataType(DataType.DateTime)]
        [DisplayName("Date of Treatment")]
        public DateTime TreatmentDate { get; set; }

        [DisplayName("Type of Treatment")]
        public string TreatmentType { get; set; }

        [DisplayName("Medications Administered")]
        public string MedicationsAdministered { get; set; }

        [DisplayName("Dosage Administered")]
        public int Dosage { get; set; }

        [DisplayName("Affected Area")]
        public string AffectedAreaOrIllness { get; set; }

        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }

        [DataType(DataType.MultilineText)]
        [DisplayName("Outcome/Change")]
        public string OutComeOrChange { get; set; }

        [DisplayName("Animal")]
        [Required(ErrorMessage = "Please select an animal")]
        public virtual AnimalModels.Animal AnimalId { get; set; }

        #region CustomValidation
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (!string.IsNullOrWhiteSpace(MedicationsAdministered) && Dosage == 0)
                yield return new ValidationResult("Please enter dosage");
        }
        #endregion
    }
}