﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnightOwlMVC.Models.Animal
{
    public class Helpline
    {
        public int HelplineId { get; set; }

        public string NameOfCaller { get; set; }

        public string LocationOfCaller { get; set; }

        public int TelephoneOfCaller { get; set; }

        public string Injury { get; set; }

        public string RefferedTo { get; set; }

        public string Outcome { get; set; }

        public virtual Animal AnimalId { get; set; }

        public virtual Staff StaffId { get; set; }
    }
}