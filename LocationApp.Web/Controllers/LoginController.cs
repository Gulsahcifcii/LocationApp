﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LocationApp.Web.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Auth()
        {
            return View();
        }
    }
}