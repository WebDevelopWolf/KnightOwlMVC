using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KnightOwlMVC.Models.ConsumerModels
{
    public class Product
    {
        [ScaffoldColumn(false)]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Please create a product title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please create a product cost")]
        public double Cost { get; set; }

        [DisplayName("Net Price")]
        [Required(ErrorMessage = "Please create a Net Price")]
        public double NetPrice { get; set; }

        [DisplayName("VAT Cost")]
        [Required(ErrorMessage = "Please create a VAT Cost")]
        public double VatCost { get; set; }

        [DisplayName("Discounted Price")]
        public double DiscountedPrice { get; set; }

        [DisplayName("Web Discount")]
        public double WebDiscount { get; set; }

        public byte[] Picture { get; set; }

        [Required(ErrorMessage = "Please create a product description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please create a product category")]
        public string Category { get; set; }
    }
}