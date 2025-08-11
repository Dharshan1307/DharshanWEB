using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DharshanWEB.Models;

namespace DharshanWEB.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: Portfolio
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCusValuesPost(PortDataValues portDataValues)
        {
            PortoDatas process = new PortoDatas();
            string status = process.AddCusValuesPost(portDataValues);
            if (status == "true")
            {
                ViewBag.Message = "Customer details added successfully.";
            }
            else
            {
                ViewBag.Message = status;
            }
            return View("Index", ViewBag);
        }
    }
}