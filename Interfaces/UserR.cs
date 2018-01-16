using System;
using System.Collections.Generic;
using Entities;
using DataService;

namespace Repositories
{
    public class UserR : IUserR
    {
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
            return _service.AddUser(aNewUser);
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
