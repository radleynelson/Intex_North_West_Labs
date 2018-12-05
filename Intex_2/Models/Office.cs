using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Intex_2.Models
{
    [Table("Office")]
    public class Office
    {
        [Key]
        public int officeID { get; set; }

        public string officeName { get; set; }

        public string officeAddress { get; set; }

        public string officeCity { get; set; }

        public string officeState { get; set; }

        public string officeCountry { get; set; }

        public Nullable<int> officeZip { get; set; }
    }
}