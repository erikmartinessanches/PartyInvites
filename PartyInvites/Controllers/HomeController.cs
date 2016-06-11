using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good afternoon";
            return View();
        }
        public ViewResult Books() {
            return View();
        }
        public RedirectResult Formula() {
            return Redirect("https://www.rare.co.uk");
        }
    }
}