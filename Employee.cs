using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectMVC.Models
{
    public class Employee
    {
        [Required]
        [RegularExpression("^[0-9]{8}$", ErrorMessage = "Please enter 8 digits in customer number")]
        [Key]
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
        public DateTime StartDate { get; set; }
        public string Color
        {
            get
            {
                if (Salary < 3000)
                    return "red";
                else
                    return "green";

            }
        }
    }
}