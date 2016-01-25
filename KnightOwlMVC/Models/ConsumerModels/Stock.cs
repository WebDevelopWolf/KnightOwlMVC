using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KnightOwlMVC.Models.ConsumerModels
{
    public class Stock
    {
        [ScaffoldColumn(false)]
        public int StockId { get; set; }

        [DisplayName("Product")]
        [Required(ErrorMessage = "Select a product")]
        public virtual Product ProductId { get; set; }

        [DisplayName("Warehouse")]
        [Required(ErrorMessage = "Select a warehouse")]
        public virtual Warehouse WarehouseId { get; set; }

        [DisplayName("Stock Level")]
        [Required(ErrorMessage = "Enter number of stock")]
        public int StockNo { get; set; }

        [DisplayName("Re-supply Level")]
        [Required(ErrorMessage = "Enter re-supply level")]
        public int ResupplyLevel { get; set; }
    }
}