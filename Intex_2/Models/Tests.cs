using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Intex_2.Models
{
    [Table("Tests")]
    public class Tests
    {
        [Key]
        public int testID { get; set; }
        public string testDescription { get; set; }
        public double price { get; set; }
    }
}