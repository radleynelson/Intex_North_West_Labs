using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Intex_2.Models
{
    [Table("Invoices")]
    public class Invoices
    {
        [Key]
        public int invoiceNo { get; set; }
        public Nullable<int> clientID { get; set; }
        public Nullable<int> cost { get; set; }
        public string salesTax { get; set; }
        public Nullable<int> totalCost { get; set; }
        public Nullable<int> advancedMoneyReduction { get; set; }
        public Nullable<System.DateTime> dateDue { get; set; }
        public Nullable<System.DateTime> earlyDate { get; set; }
        public Nullable<double> earlyDiscount { get; set; }
    }
}