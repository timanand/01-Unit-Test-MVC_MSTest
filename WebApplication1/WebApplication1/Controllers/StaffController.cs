using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Added by AANA
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class StaffController : Controller
    {
        public IActionResult Index()
        {
            //return View(""); // default
            return View("Index");
        }

        public ActionResult About()
        {
            ViewData["Title"] = "Your application description page.";
            return View();
        }

        public IActionResult zzz()
        {
            Employee emp = new Employee()
            {
                Id = 1,
                Name = "Nitish"
            };
            return View("zzz", emp);
        }


    }
}
