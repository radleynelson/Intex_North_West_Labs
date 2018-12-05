using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Intex_2.Models
{
    [Table("Assays_Tests")]
    public class Assays_Tests
    {
        public int assayID { get; set; }
        public int testID { get; set; }
        public string required { get; set; }
    }
}