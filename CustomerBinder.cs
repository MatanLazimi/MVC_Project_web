using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectMVC.Models;
namespace ProjectMVC.ModelBinders
{
    public class CustomerBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            HttpContextBase objContext = controllerContext.HttpContext;
            string customerFirstName = objContext.Request.Form["txtFirstName"];
            string customerLastName = objContext.Request.Form["txtLastName"];
            string customerCostumerNumber = objContext.Request.Form["txtCustomerNumber"];

            Customer obj = new Customer()
            {
                FirstName = customerFirstName,
                LastName = customerLastName,
                CustomerNumber = customerCostumerNumber
            };
            return obj;
        }
    }
}