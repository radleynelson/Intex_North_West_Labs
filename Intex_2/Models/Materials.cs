using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Intex_2.Models
{
    [Table("Materials")]
    public class Materials
    {
        [Key]
        public int materialID { get; set; }

        public string materialName { get; set; }

        public Nullable<double> availableQty { get; set; }

        public Nullable<double> qtyThreshold { get; set; }

        public Nullable<double> avgCost { get; set; }
    }
}