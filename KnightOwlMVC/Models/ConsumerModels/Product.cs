using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnightOwlMVC.Models.ConsumerModels
{
    public class Product
    {
        public int ProductId { get; set; }

        public string Title { get; set; }

        public double Cost { get; set; }

        public double NetPrice { get; set; }

        public double VatCost { get; set; }

        public double DiscountedPrice { get; set; }

        public double WebDiscount { get; set; }

        public byte[] Picture { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }
    }
}