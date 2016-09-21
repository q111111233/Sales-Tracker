using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SalesTracker.Models
{
    [Table("Inventories")]
    public class Inventory
    {
        [Key]
        public int InventoryId { get; set; }
        public int Unit { get; set; }
        public string Item { get; set; }
        public int Cost { get; set; }

        public int SalePrice { get; set; } 

        public virtual ApplicationUser User { get; set; }
    }
}
