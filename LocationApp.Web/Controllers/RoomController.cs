﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LocationApp.Web.Controllers
{
    public class RoomController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
    }
}