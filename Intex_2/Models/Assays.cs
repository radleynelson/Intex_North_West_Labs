using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Intex_2.Models
{
    [Table("Assays")]
    public class Assays
    {
        [Key]
        public int assayID { get; set; }
        public string assayType { get; set; }
        public Nullable<int> daysToComplete { get; set; }
        public Nullable<double> minPriceQuote { get; set; }
        public Nullable<double> maxPriceQuote { get; set; }
        public string assayProtocol { get; set; }
    }
}