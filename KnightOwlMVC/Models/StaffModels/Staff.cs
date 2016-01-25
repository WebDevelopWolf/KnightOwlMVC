using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using KnightOwlMVC.Models.CustomerModels;

namespace KnightOwlMVC.Models.StaffModels
{
    public class Staff : IValidatableObject
    {
        [ScaffoldColumn(false)]
        public int StaffId { get; set; }

        [Required(ErrorMessage = "Enter a first name")]
        public string Forename { get; set; }

        [Required(ErrorMessage = "Enter a surma,e")]
        public string Surname { get; set; }

        [DisplayName("Staff Type (Full-Time, Volunteer etc.)")]
        [Required(ErrorMessage = "Select the type of staff member this person is")]
        public string Type {get; set;}

        [DisplayName("Is the member of staff a placement student?")]
        public bool Placement { get; set; }

        [DisplayName("College/University")]
        public string EduInst { get; set; }

        [DisplayName("College/University Contact")]
        public string EduContact { get; set; }

        [DisplayName("Date Employment Started")]
        [Required(ErrorMessage = "Select  the date the employee started")]
        [DataType(DataType.Date)]
        public DateTime Started { get; set; }

        [DisplayName("Date Employment Terminated")]
        [DataType(DataType.Date)]
        public DateTime Ended { get; set; }

        [DisplayName("Employee Status (e.g. Employed, Retired etc.)")]
        [Required(ErrorMessage = "Select a status for the employee")]
        public string Status { get; set; }

        [DisplayName("Does the meployee have a driving licence?")]
        public bool DrivingLicence { get; set; }

        [DisplayName("Has the employee been briefed on Health and Safety?")]
        public bool HealthSaftey { get; set; }

        [DisplayName("Has the Employee had their tetnus shot?")]
        public bool Tetnus { get; set; }

        [DisplayName("Employee Doctor Name")]
        [Required(ErrorMessage = "Enter the employee's doctor")]
        public string DoctorsName { get; set; }

        [DisplayName("Employee Doctor Contact")]
        [Required(ErrorMessage = "Enter a contact number for the employee's doctor")]
        public string DoctorContact { get; set; }

        [DisplayName("Next of Kin")]
        [Required(ErrorMessage = "Enter a Next of Kin")]
        public string NextOfKin { get; set; }

        [DisplayName("Next Of Kin / Emergency Contact")]
        [Required(ErrorMessage = "Employee must have an emergency contact")]
        public string NextOfKinContact { get; set; }

        [DisplayName("Is employee a recognised First Aider?")]
        public bool FirstAid { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("First Aid Expiry Date")]
        public DateTime FirstAidExp { get; set; }

        [DisplayName("Is employee a recognised Fire Warden?")]
        public bool FireWarden { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Fire Warden Expiry Date")]
        public DateTime FireWardenExp { get; set; }

        #region CustomValidation
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Placement == true && string.IsNullOrWhiteSpace(EduInst))
                yield return new ValidationResult("Placement students must be associated with a college or university");

            if (Placement == true && string.IsNullOrWhiteSpace(EduContact))
                yield return new ValidationResult("Placement students must have a professional contact");
        }
        #endregion
    }
}