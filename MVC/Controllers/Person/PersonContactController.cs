using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers.Person
{
    public class PersonContactController : Controller
    {
        // GET: PersonContact
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection formCollection)
        {
            return View();
        }
        [HttpGet]
        public ActionResult CreateContact(Contact model)
        {
            Response.Write(model.ContactID);
            return View();
        }
        [HttpPost]
        public ActionResult CreateContact(FormCollection formCollection, Contact model)
        {
            foreach (String item in formCollection.AllKeys)
            {
                Response.Write(item);
                Response.Write("<br/>");
            }
            return View();
        }
        /**[HttpPost]
        public ActionResult Index()
        {
            return View();
        }*/
    }
}