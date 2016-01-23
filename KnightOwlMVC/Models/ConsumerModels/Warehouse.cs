using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnightOwlMVC.Models.ConsumerModels
{
    public class Warehouse
    {
        public int WarehouseId { get; set; }

        public int WarehouseCode { get; set; }

        public string WarehouseName { get; set; }

        public string WarehouseLocation { get; set; }
    }
}