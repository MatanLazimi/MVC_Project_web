using System;
using System.ComponentModel.DataAnnotations;
namespace ProjectMVC.Models
{
    public class Login_user
    {
        [Required]
        //[StringLength(50, MinimumLength = 8)]
        [RegularExpression("^[0-9]{8}$", ErrorMessage = "Please enter 8 digits in customer number")]
        [Key]
        public string ID { get; set; }
        [Required]
        public string Password { get; set; }
        public int Type { get; set; }
    }
}