using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnightOwlMVC.Models.Animal
{
    public class Feeding
    {
        public int FeedingId { get; set; }

        public virtual Animal AnimalId { get; set; }

        public string Day { get; set; }

        public string Amount { get; set; }

        public string Food { get; set; }
    }
}