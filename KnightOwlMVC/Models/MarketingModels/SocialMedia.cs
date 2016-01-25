using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KnightOwlMVC.Models.MarketingModels
{
    public class SocialMedia
    {
        [ScaffoldColumn(false)]
        public int SocialMediaId { get; set; }

        [DisplayName("Socail Media Site")]
        [Required(ErrorMessage = "Select a site")]
        public string Type { get; set; }

        [DisplayName("Id number of account")]
        public int SocialId { get; set; }

        [DisplayName("Social Username/Page Name")]
        public string SocialUnique { get; set; }
    }
}