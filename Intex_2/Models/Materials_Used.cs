using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Intex_2.Models
{
    [Table("Materials_Used")]
    public class Materials_Used
    {
        [Key]
        [Column(Order = 1)]
        public int materialID { get; set; }
        [Key]
        [Column(Order = 2)]
        public int testID { get; set; }
        public double qtyUsed { get; set; }

    }
}