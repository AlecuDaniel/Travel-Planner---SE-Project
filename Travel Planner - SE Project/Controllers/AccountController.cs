﻿using Microsoft.AspNetCore.Mvc;

namespace Travel_Planner___SE_Project.Controllers
{
    public class AccountController : Controller
    {

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}
