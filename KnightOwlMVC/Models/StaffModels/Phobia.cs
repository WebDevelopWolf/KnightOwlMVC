using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KnightOwlMVC.Models.StaffModels
{
    public class Phobia
    {
        [ScaffoldColumn(false)]
        public int PhobiaId { get; set; }

        [DisplayName("Staff")]
        [Required(ErrorMessage = "Select a Staff Member")]
        public virtual Staff StaffId { get; set; }

        [DisplayName("Phobia Of")]
        [Required(ErrorMessage = "Enter staff members phobia")]
        public string PhobiaOf { get; set; }

        [DisplayName("What are the person's limits to their phobia")]
        [Required(ErrorMessage = "Enter any actions staff member is able to perform with this phobia")]
        public string VolunteerLimits { get; set; }
    }
}