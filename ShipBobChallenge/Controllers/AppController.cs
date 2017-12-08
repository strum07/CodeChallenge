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


        [HttpGet("adduser")]
        public IActionResult AddUser()
        { 
           return View();
        }

        [HttpPost("adduser")]
        public IActionResult AddUser(object model)
        {
            return View();
        }


        public IActionResult CreateOrder()
        {
            return View();
        }


        public IActionResult UserOrders()
        {
          
            //throw new InvalidOperationException("Bad things happen!");
            return View();
        }


    }
}