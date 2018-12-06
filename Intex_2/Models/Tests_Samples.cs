using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Intex_2.Models
{
    [Table("Tests_Samples")]
    public class Tests_Samples
    {
        [Key]
        [Column(Order = 1)]
        public int testID { get; set; }
        [Key]
        [Column(Order = 2)]
        public Nullable<int> compoundSequenceCode { get; set; }
        public Nullable<int> resultID { get; set; }
        public Nullable<double> manHours { get; set; }
    }
}