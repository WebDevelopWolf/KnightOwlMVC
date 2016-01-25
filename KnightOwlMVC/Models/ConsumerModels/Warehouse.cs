using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KnightOwlMVC.Models.ConsumerModels
{
    public class Warehouse
    {
        [ScaffoldColumn(false)]
        public int WarehouseId { get; set; }

        [DisplayName("Warehouse Code")]
        [Required(ErrorMessage = "Please create a Warehouse Code")]
        [Range(1,4)]
        public int WarehouseCode { get; set; }

        [DisplayName("Warehouse Name")]
        [Required(ErrorMessage = "Please create a Warehouse Name")]
        public string WarehouseName { get; set; }

        [DisplayName("Warehouse Location")]
        [Required(ErrorMessage = "Please create a Warehouse Location")]
        public string WarehouseLocation { get; set; }
    }
}