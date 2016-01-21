using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace KnightOwlMVC.Models.Animal
{
    public class RehomingLog
    {
        public int RehomingLogId { get; set; }

        public virtual Customer RehomingFrom { get; set; }

        public DateTime RemhomingDate { get; set; }

        public virtual CustomError RehomingTo { get; set; }

        public string Notes { get; set; }

        public virtual Animal AnimalId { get; set; }
    }
}