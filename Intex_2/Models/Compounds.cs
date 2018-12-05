using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Intex_2.Models
{
    [Table("Compounds")]
    public class Compounds
    {
        [Key]
        public int compoundID { get; set; }
        public string compoundName { get; set; }
        public Nullable<int> workOrderID { get; set; }
        public Nullable<double> weight { get; set; }
        public Nullable<double> maxToleratedDose { get; set; }
        public Nullable<int> LTNumber { get; set; }
        public Nullable<System.DateTime> dateArrived { get; set; }
        public string employeeReceivedBy { get; set; }
        public Nullable<System.DateTime> dateEmailSent { get; set; }
    }
}