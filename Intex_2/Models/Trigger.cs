using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Intex_2.Models
{
    [Table("Trigger")]
    public class Trigger
    {
        [Key]
        public int triggerID { get; set; }
        public string triggerDescription { get; set; }
    }
}