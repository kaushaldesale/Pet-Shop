using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Micraft_Solutions.Models
{
    public class Product
    {
        public int Product_Id { get; set; }
        public string Product_Code { get; set; }
        public string Product_Name { get; set; }
        public HttpPostedFileBase Product_Image { get; set; }
        //public string Product_Image { get; set; }
        public string Product_Unit { get; set; }
        public Nullable<decimal> Product_Rate { get; set; }
        public string Product_Description { get; set; }
        public string image_path { get; set; }
    }
}