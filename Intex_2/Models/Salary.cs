using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Intex_2.Models
{
    [Table("Salary")]
    public class Salary
    {
        [Key]
        public int salaryID { get; set; }

        public Nullable<double> salaryAmount { get; set; }
    }
}