using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TypicalTools.Models
{
    // Sets the product model values/info
    public class Product
    {
        // Sets the product code as primary key in database 
        [Key] 
        public int ProductCode { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public DateTime? UpdatedDate { get; set; } = DateTime.Now;
    }
}
