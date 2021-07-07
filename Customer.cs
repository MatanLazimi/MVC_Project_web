using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectMVC.Models
{
    public class Customer
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50,MinimumLength =2,ErrorMessage ="Lenght must be between 2 and 50 characters")]
        public string LastName { get; set; }
        [Key]
        [Required]
        [RegularExpression("[0-9]{4}$", ErrorMessage = "Customer number sould contain 4 digits")]
        public string CustomerNumber { get; set; }
    }
}