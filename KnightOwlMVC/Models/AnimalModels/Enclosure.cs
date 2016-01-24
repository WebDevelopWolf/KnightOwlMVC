using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnightOwlMVC.Models.AnimalModels
{
    public class Enclosure
    {
        public int EnclosureId { get; set; }

        public string EnclosureName { get; set; }

        public string Location { get; set; }
    }
}