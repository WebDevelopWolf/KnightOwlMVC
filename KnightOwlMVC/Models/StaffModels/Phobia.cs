using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnightOwlMVC.Models.StaffModels
{
    public class Phobia
    {
        public int PhobiaId { get; set; }

        public virtual Staff StaffId { get; set; }

        public string PhobiaOf { get; set; }

        public string VolunteerLimits { get; set; }
    }
}