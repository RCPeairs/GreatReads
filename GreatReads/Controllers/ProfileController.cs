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

        //private User MakeTestRecord()
        //{
        //    User vtestRecord = new User
        //    {
        //         Id = 0
        //        ,UserName = "TestUser"
        //        ,Password = "123"
        //        ,FirstName = "Test"
        //        ,LastName = "User"
        //        ,StreetAddress = "123 AnyStreet"
        //        ,City = "AnyTown"
        //        ,State = "AZ"
        //        ,Zip = "85248"
        //        ,Email = "TestUser@Yahoo.Com"
        //        ,Phone = "123-4567"
        //        ,Avatar = "Cliffs"
        //        ,AdminNotes = "This is an admin note."
        //        ,Administrator = false
        //        ,Member = true
        //        ,PendingMember = false
        //        ,TextNewMember = true
        //        ,TextNewActivity = false
        //        ,TextChangeMyActivity = true
        //        ,TextNewBook = false
        //        ,TextNewBBPost = true
        //        ,EmailNewMember = false
        //        ,EmailNewActivity = true
        //        ,EmailChangeMyActivity = false
        //        ,EmailNewBook = true
        //        ,EmailNewBBPost = false
        //    };

        //    return vtestRecord;
        //}

    }
}