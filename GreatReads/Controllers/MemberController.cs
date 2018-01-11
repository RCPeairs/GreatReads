using GreatReads.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Repositories;

namespace GreatReads.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Member()
        {
            var repository = new UserR();
            var members = repository.GetAllUsers();

            return View(members);
        }
    }
}
