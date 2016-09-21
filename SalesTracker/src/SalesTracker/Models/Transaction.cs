using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SalesTracker.Models
{
    [Table("Transactions")]
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        public int UnitSold { get; set; }
        public int Revenue { get; set; }
        public int Return { get; set; }
        public string Comment { get; set; }
        public int Commission { get; set; }

        public virtual ApplicationUser User { get; set; }

    }
}
