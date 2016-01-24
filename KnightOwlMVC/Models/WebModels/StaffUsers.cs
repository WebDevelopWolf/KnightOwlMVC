using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnightOwlMVC.Models.WebModels
{
    public class StaffUsers
    {
        public int StaffUsersId { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string AccessLevel { get; set; }

        public DateTime LastLogin { get; set; }

        public string UserAgent { get; set; }

        public byte[] Picture { get; set; }
    }
}