using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KnightOwlMVC.Models.WebModels
{
    public class MobileSetting
    {
        [ScaffoldColumn(false)]
        public int MobileSettingId { get; set; }

        [DisplayName("Toggle Mobile Site")]
        public bool Mobile { get; set; }
    }
}