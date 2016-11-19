using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dependency.DLL;

namespace DependencyResolverTemplate.Controllers
{
    public class HomeController : Controller
    {
        public ICustomer Customer { get; set; }

        public HomeController(ICustomer customer)
        {
            this.Customer = customer;
        }

        public ActionResult Index()
        {
            ViewBag.Message = Customer.GetCustomer(1);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}