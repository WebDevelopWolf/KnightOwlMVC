using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnightOwlMVC.Models.Animal
{
    public class KeeperLog
    {
        public int KeeperLogId { get; set; }

        public DateTime IncidentDateTime { get; set; }

        public string Notes { get; set; }

        public virtual Animal AnimalId { get; set; }

        public virtual Staff StaffId { get; set; }
    }
}