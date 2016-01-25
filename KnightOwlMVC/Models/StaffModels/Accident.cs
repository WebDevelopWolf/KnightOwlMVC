using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KnightOwlMVC.Models.StaffModels
{
    public class Accident
    {
        [ScaffoldColumn(false)]
        public int AccidentId { get; set; }

        [DisplayName("Staff")]
        [Required(ErrorMessage = "Select a Staff member")]
        public virtual Staff StaffId { get; set; }

        [DisplayName("Date of Incident")]
        [Required(ErrorMessage = "Record the date and time of the incident")]
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Record the location of the incident")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Record the cause of the incident")]
        public string Cause { get; set; }

        [Required(ErrorMessage = "Record any injury suffered")]
        public string Injury { get; set; }

        public string Treatment { get; set; }

        public bool FurtherTreatment { get; set; }
    }
}