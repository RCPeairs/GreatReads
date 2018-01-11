using System;
using System.Collections.Generic;
using Entities;
using DataService;

namespace Repositories
{
    public class UserR : IUserR
    {
        //private readonly User _user = new User();
        private readonly DataServices _service = new DataServices();

        public IList<User> GetAllUsers()
        {
            return _service.GetAllUsers();
        }

        public User GetUserById(int aUserId)
        {
            throw new NotImplementedException();
        }

        public int AddUser(User aNewUser)
        {
            throw new NotImplementedException();
        }

        public int EditUser(User aUser)
        {
            throw new NotImplementedException();
        }

        public int DeleteUser(int aUserId)
        {
            throw new NotImplementedException();
        }
    }
}
