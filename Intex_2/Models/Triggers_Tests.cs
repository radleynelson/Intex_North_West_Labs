using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Intex_2.Models
{
    [Table("Triggers_Tests")]
    public class Triggers_Tests
    {
        [Key]
        [Column(Order = 1)]
        public int triggerID { get; set; }
        [Key]
        [Column(Order = 2)]
        public int testID { get; set; }
      
    }
}