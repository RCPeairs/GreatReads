﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GreatReads.Controllers
{
    public class ResourcesController : Controller
    {
        public IActionResult Resources()
        {
            return View();
        }
    }
}