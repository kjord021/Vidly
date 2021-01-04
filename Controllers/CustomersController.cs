using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var customers = GetCustomers();

            var viewModel = new CustomerMovieViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }

        [Route("Customers/Details/{ID}")]
        public ActionResult Details(int id) 
        {

            var customer = GetCustomers().SingleOrDefault(c => c.ID == id);

            if (customer == null) 
            {
                return HttpNotFound();
            }

            return View(customer);

        }

        private List<Customer> GetCustomers() 
        {
            var customers = new List<Customer>
            {
                new Customer { Name = "John Smith", ID = 1},
                new Customer { Name = "Mary Williams", ID = 2}
            };

            return customers;
        }
    }
}