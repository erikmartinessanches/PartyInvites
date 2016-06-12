using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartyInvites.Models; /*So I can refer to the GuestResponse model type 
without needing to qualify the class name.*/

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
        [HttpGet]
        public ViewResult RsvpForm() {
            return View();
        }
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        { /*The GuestResponse object that is passed as the parameter to the 
            action method is automatically populated with the data from the 
            form fields, due to model binding (the names of the input elements
            are used to set the vaules of the properties in an instance of
            the model class, which is then passed to the POST-enabled action
            method).*/

            //TODO: Email response to the party organizer.
            if (ModelState.IsValid)
            {
                return View("Thanks", guestResponse); //Render a specific view.
            }
            else {
                //there's a validation error
                return View();
            }
        }
        public ViewResult Books() {
            return View();
        }
        public RedirectResult Formula() {
            return Redirect("https://www.rare.co.uk");
        }
    }
}