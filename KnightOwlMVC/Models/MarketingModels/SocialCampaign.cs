using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnightOwlMVC.Models.MarketingModels
{
    public class SocialCampaign
    {
        public int SocialCampaignId { get; set; }

        public string Name { get; set; }

        public string Hashtag { get; set; }

        public string Keywords { get; set; }

        public virtual SocialMedia SocialMediaId { get; set; }
    }
}