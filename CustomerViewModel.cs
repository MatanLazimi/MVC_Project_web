using ProjectMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectMVC.ModelView
{
    public class CustomerViewModel
    {
        public Manager manager { get; set; }
        public Customer customer { get; set; }
        public List<Customer> customers { get; set; }
    }
}