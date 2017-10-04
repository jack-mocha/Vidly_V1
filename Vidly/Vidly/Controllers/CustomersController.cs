using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext();//It is a disposable object
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();  
        }

        // GET: Customers
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();

            CustomersViewModel viewModel = new CustomersViewModel()
            {
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "Scott Hsu" },
                new Customer { Id = 2, Name = "Jack Hsu" }
            };
        }
    }
}