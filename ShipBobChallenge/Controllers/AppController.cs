﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShipBobChallenge.ViewModels;

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
        public IActionResult AddUser(UserViewModel model)
        {

            if (ModelState.IsValid)
            {
                //do something and

                
            }
            else
            {
                //Show what's wrong
            }

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