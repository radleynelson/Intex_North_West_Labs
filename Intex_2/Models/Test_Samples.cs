using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Intex_2.Models
{
    [Table("Test_Samples")]
    public class Test_Samples
    {
        [Key]
        public int testID { get; set; }
        public Nullable<int> compoundSequenceCode { get; set; }
        public Nullable<int> resultID { get; set; }
        public Nullable<double> manHours { get; set; }
    }
}