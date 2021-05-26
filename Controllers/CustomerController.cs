using CustomersWithAjax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomersWithAjax.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        readonly List<CustomerModel> Customers;
        public CustomerController()
        {
            Customers = new List<CustomerModel>()
            {
                new CustomerModel(0,"Igor",37),
                new CustomerModel(1,"Vasya",27),
                new CustomerModel(2,"Misha",71),
                new CustomerModel(3,"Zhenya",30),
                new CustomerModel(4,"Danila",12),
                new CustomerModel(5,"Egor",17),
                new CustomerModel(6,"Leshka",20)
            };
        }

        public ActionResult Index()
        {
            //in this case i will hard-code entities
            Tuple<List<CustomerModel>, CustomerModel> tuple;
            tuple = new Tuple<List<CustomerModel>, CustomerModel>(Customers, Customers[2]);

         
            return View("Customer",tuple);
        }

        [HttpPost]
        public ActionResult OnSelectCustomer(string CustomerNumber)
        {
            //in this case i will hard-code entities
            Tuple<List<CustomerModel>, CustomerModel> tuple;
            tuple = new Tuple<List<CustomerModel>, CustomerModel>(Customers, Customers[int.Parse(CustomerNumber)]);


            return PartialView("_CustomerDetails", Customers[int.Parse(CustomerNumber)]);
        }
    }
}