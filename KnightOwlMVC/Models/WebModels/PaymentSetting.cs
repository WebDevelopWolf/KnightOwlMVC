using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KnightOwlMVC.Models.WebModels
{
    public class PaymentSetting
    {
        [ScaffoldColumn(false)]
        public int PaymentSettingId { get; set; }

        [DisplayName("Toggle Online Booking")]
        public bool OnlineBooking { get; set; }

        [DisplayName("Payment Method")]
        [Required(ErrorMessage = "Choose a payment method for the online booking site")]
        public string PaymentMethod { get; set; }

        public string PayPal { get; set; }

        public string SagePay { get; set; }

        public string WorldPay { get; set; }

        public string SecureTrading { get; set; }

        public string RealEx { get; set; }
    }
}