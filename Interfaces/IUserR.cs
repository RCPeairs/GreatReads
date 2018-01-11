using System.Collections.Generic;
using Entities;

namespace Repositories
{
    public interface IUserR
    {
        IList<User> GetAllUsers();
        User GetUserById(int aUserId);
        int AddUser(User aNewUser);
        int EditUser(User aUser);
        int DeleteUser(int aUserId);
    } 
}
