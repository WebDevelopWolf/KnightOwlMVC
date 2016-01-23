using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnightOwlMVC.Models.StaffModels
{
    public class Medical
    {
        public int MedicalId { get; set; }

        public string MedicalCondition { get; set; }

        public string Medication { get; set; }

        public string Notes { get; set; }

        public virtual Staff StaffId { get; set; }
    }
}