using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Intex_2.Models
{
    [Table("Client")]
    public class Client
    {
        [Key]
        public int clientID { get; set; }
        public string clientName { get; set; }
        public Nullable<double> advancedMoneyBalance { get; set; }
        public string clientEmail { get; set; }
        public string clientPhone { get; set; }
        public string clientAddress { get; set; }
        public string clientCity { get; set; }
        public string clientState { get; set; }
        public string clientCountry { get; set; }
        public Nullable<int> clientZip { get; set; }
        public Nullable<int> userID { get; set; }
        public string paymentInfo { get; set; }
    }
}