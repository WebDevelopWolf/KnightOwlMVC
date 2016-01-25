using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KnightOwlMVC.Models.AnimalModels
{
    public class RescueCentre
    {
        [ScaffoldColumn(false)]
        public int RescueCentreId { get; set; }

        [DisplayName("Rescue Centre Name")]
        [Required(ErrorMessage = "Rescue must have a name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Rescue must have a contact")]
        [DisplayName("Rescue Centre Contact")]
        public string Contact { get; set; }

        [Required(ErrorMessage = "Rescue must have a location")]
        [DisplayName("Rescue Centre Location")]
        [DataType(DataType.PhoneNumber)]
        public string Location { get; set; }
    }
}