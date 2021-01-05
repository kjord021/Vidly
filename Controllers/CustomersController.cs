using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {

        private VidlyDBContext _context;

        public CustomersController()
        {
            _context = new VidlyDBContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customer
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();

            var viewModel = new CustomerMovieViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }

        [Route("Customers/Details/{ID}")]
        public ActionResult Details(int id) 
        {

            var customer = _context.Customers.SingleOrDefault(c => c.ID == id);

            if (customer == null) 
            {
                return HttpNotFound();
            }

            return View(customer);

        }
    }
}