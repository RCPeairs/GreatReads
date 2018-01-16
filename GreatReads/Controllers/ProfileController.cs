using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Constant;
using Entities;
using Repositories;

namespace GreatReads.Controllers
{
    public class ProfileController : Controller
    {
        private readonly IUser _user;

        public ProfileController(IUser auser)
        {
            _user = auser ?? throw new ArgumentNullException(nameof(auser));
        }

        public IActionResult AddEditProfile(User auser)
        {
            IUserR vrepository = new UserR();
            int vreturnCode = vrepository.AddUser(auser);
            string vmsg;

            // Verify add user was successfull
            if (vreturnCode == Constants.successCode)
            {
                vmsg = "User added. ";
            }
            else
            {
                vmsg = "Add user failed. ";
            }
            return View();
        }
      }
}