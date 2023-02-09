using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Micraft_Solutions.Models
{
    public class Register
    {
        public int Customer_id { get; set; }
        public string Customer_Name { get; set; }
        public string Customer_Address { get; set; }
        public string email_id { get; set; }
        public string Contact_No { get; set; }
        public string Password { get; set; }
    }
}