using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.DbModel;

namespace WebAPI.Repository
{
    public interface IUserRepository
    {
        IEnumerable<Users> GetAllUsers();
        void AddUser(Users user);

        Users GetUserById(int id);
    }
}
