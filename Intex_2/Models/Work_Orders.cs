using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Intex_2.Models
{
    [Table("Work_Orders")]
    public class Work_Orders
    {
        [Key]
        public int workOrderID { get; set; }
        public int employeeID { get; set; }
        public int clientID { get; set; }
        public string comments { get; set; }
        public Nullable<int> LTNumber { get; set; }
        public Nullable<int> invoiceNo { get; set; }
        public string workOrderStatus { get; set; }
        public Nullable<System.DateTime> dateDue { get; set; }
    }
}