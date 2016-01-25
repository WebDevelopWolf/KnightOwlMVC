using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KnightOwlMVC.Models.StaffModels
{
    public class StaffContact
    {
        [ScaffoldColumn(false)]
        public int StaffContactId { get; set; }

        [DisplayName("Contact Method")]
        [Required(ErrorMessage = "Enter a contact method")]
        public string Method { get; set; }

        [DisplayName("Contact")]
        [Required(ErrorMessage = "Enter a contact (e.g. phone, email etc.")]
        public string ContactSpecific { get; set; }

        [DisplayName("Staff")]
        [Required(ErrorMessage = "Select a Staff Member")]
        public virtual Staff StaffId { get; set; }
    }
}