using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnightOwlMVC.Models.StaffModels
{
    public class StaffContact
    {
        public int ContactId { get; set; }

        public string Method { get; set; }

        public string ContactSpecific { get; set; }

        public virtual Staff StaffId { get; set; }
    }
}