using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KnightOwlMVC.Models.WebModels
{
    public class StaffUsers
    {
        [ScaffoldColumn(false)]
        public int StaffUsersId { get; set; }

        [Required(ErrorMessage = "Enter a username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Enter a password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Access Level")]
        [Required(ErrorMessage = "Select an access level")]
        public string AccessLevel { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime LastLogin { get; set; }

        public string UserAgent { get; set; }

        public byte[] Picture { get; set; }
    }
}