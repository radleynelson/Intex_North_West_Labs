using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Intex_2.Models
{
    [Table("Triggers_Tests")]
    public class Triggers_Tests
    {
        public int triggerID { get; set; }
        public int testID { get; set; }
      
    }
}