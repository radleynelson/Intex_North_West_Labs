using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Intex_2.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int employeeID { get; set; }
        public string employeeName { get; set; }
        public Nullable<int> officeID { get; set; }
        public string employeePosition { get; set; }
        public string employeeEmail { get; set; }
        public string employeePhone { get; set; }
        public string employeeAddress { get; set; }
        public string employeeCity { get; set; }
        public string employeeState { get; set; }
        public string employeeCountry { get; set; }
        public Nullable<int> employeeZip { get; set; }
        public Nullable<int> salaryID { get; set; }
        public Nullable<int> userID { get; set; }
    }
}