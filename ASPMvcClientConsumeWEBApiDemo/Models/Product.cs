using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASPMvcClientConsumeWEBApiDemo.Models
{
    public class Product
    {
        //Serialization: ???

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductCode { get; set; }
        [Required(ErrorMessage = "Product Name Should not be blank")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Product price should not be blank")]
        public decimal ProductPrice { get; set; }
    }
}
