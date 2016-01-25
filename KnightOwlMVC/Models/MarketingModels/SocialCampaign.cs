using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KnightOwlMVC.Models.MarketingModels
{
    public class SocialCampaign
    {
        [ScaffoldColumn(false)]
        public int SocialCampaignId { get; set; }

        [DisplayName("Campaign Name")]
        [Required(ErrorMessage = "Select a name for your campaign")]
        public string Name { get; set; }

        public string Hashtag { get; set; }

        public string Keywords { get; set; }

        [DisplayName("Social Media Site")]
        [Required(ErrorMessage = "Select a media")]
        public virtual SocialMedia SocialMediaId { get; set; }
    }
}