using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectMVC.Models
{
    public class Interested
    {
        [Required]
        [RegularExpression("^[0-9]{8}$", ErrorMessage = "Please enter 8 digits in customer number")]
        [Key]
        public string ID { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

    }
}