using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnightOwlMVC.Models.ConsumerModels
{
    public class Stock
    {
        public int StockId { get; set; }

        public virtual Product ProductId { get; set; }

        public virtual Warehouse WarehouseId { get; set; }

        public int StockNo { get; set; }

        public int ResupplyLevel { get; set; }
    }
}