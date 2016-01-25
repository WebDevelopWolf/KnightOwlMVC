using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KnightOwlMVC.Models.AnimalModels
{
    public class MobileEntry
    {
        [ScaffoldColumn(false)]
        public int MobileEntryId { get; set; }

        [Required(ErrorMessage = "Entry must have a title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Entry must have a description")]
        [DisplayName("Description")]
        public string Body { get; set; }
    }
}