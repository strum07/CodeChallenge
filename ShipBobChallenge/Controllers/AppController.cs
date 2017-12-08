using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ShipBobChallenge.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet("AddUser")]
        public IActionResult AddUser()
        {
            return View();
        }

        [HttpPost("AddUser")]
        public IActionResult AddUser(object model)
        {
            return View();
        }


        public IActionResult CreateOrder()
        {

            ViewBag.Title = "Create Order";

            return View();
        }


        public IActionResult UserOrders()
        {

            ViewBag.Title = "View User Orders";

            return View();
        }


    }
}