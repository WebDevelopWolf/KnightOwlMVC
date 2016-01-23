using System;
using System.Web.Configuration;
using KnightOwlMVC.Models.CustomerModels;

namespace KnightOwlMVC.Models.AnimalModels
{
    public class RehomingLog
    {
        public int RehomingLogId { get; set; }

        public virtual Customer RehomingFrom { get; set; }

        public DateTime RemhomingDate { get; set; }

        public virtual CustomError RehomingTo { get; set; }

        public string Notes { get; set; }

        public virtual AnimalModels.Animal AnimalId { get; set; }
    }
}