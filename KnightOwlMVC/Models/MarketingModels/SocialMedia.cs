using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnightOwlMVC.Models.MarketingModels
{
    public class SocialMedia
    {
        public int SocialMediaId { get; set; }

        public string Type { get; set; }

        public int SocialId { get; set; }

        public string SocialUnique { get; set; }
    }
}