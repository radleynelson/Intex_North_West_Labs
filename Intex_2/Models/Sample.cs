using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Intex_2.Models
{
    [Table("Sample")]
    public class Sample
    {
        [Key]
        public int compoundSequenceCode { get; set; }

        public Nullable<int> compoundID { get; set; }

        public Nullable<double> clientReportedWeight { get; set; }

        public Nullable<double> companyMeasuredWeight { get; set; }

        public string appearance { get; set; }

        public Nullable<double> molecularMass { get; set; }
    }
}