using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DharshanWEB.Models;

namespace DharshanWEB.Controllers
{
    public class AdminController : Controller
    {
        
       
        public ActionResult AdminPortal()
        {
            AdminModels models = new AdminModels();
            List<Dictionary<string, string>> list = models.GetCustomer();
            ViewBag.Customer = list;
            return View(ViewBag);
        }
    }
}