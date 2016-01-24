using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KnightOwlMVC.Models.StaffModels;

namespace KnightOwlMVC.Models.WebModels
{
    public class Notification
    {
        public int NotificationId { get; set; }

        public virtual Staff StaffId { get; set; }

        public string Type { get; set; }

        public bool Seen { get; set; }
    }
}