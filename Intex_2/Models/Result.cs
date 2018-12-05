using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Intex_2.Models
{
    [Table("Result")]
    public class Result
    {
        [Key]
        public int resultID { get; set; }

        public string quantitativeResults { get; set; }

        public string qualitativeResults { get; set; }
    }
}