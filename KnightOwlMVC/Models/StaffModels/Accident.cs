using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnightOwlMVC.Models.StaffModels
{
    public class Accident
    {
        public int AccidentId { get; set; }

        public virtual Staff StaffId { get; set; }

        public DateTime Date { get; set; }

        public string Location { get; set; }

        public string Cause { get; set; }

        public string Injury { get; set; }

        public string Treatment { get; set; }

        public bool FurtherTreatment { get; set; }
    }
}