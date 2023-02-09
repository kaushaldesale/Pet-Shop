using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Micraft_Solutions.Models
{
    public class Customer
    {
        public int Customer_Id { get; set; }
        public string Customer_Name { get; set; }
       [StringLength(50, MinimumLength = 4, ErrorMessage = "Address should be minimum 4 character and maximum 50 character ")]
        public string Customer_Address { get; set; }
        public string Customer_City { get; set; }
        [StringLength(6, MinimumLength = 4, ErrorMessage = "Pin Code should be minimum 4 character and maximum 6 character ")]
        public Nullable<int> Pin_Code { get; set; }
    }
}