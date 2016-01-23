using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnightOwlMVC.Models.WebModels
{
    public class PaymentSetting
    {
        public int PaymentSettingId { get; set; }

        public bool OnlineBooking { get; set; }

        public string PaymentMethod { get; set; }

        public string PayPal { get; set; }

        public string SagePay { get; set; }

        public string WorldPay { get; set; }

        public string SecureTrading { get; set; }

        public string RealEx { get; set; }
    }
}