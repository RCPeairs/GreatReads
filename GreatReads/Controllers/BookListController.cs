﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GreatReads.Controllers
{
    public class BookListController : Controller
    {
        public IActionResult BookList()
        {
            return View();
        }
    }
}