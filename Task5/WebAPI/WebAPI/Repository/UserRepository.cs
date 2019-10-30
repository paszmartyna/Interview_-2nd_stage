using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.DbModel;

namespace WebAPI.Repository
{
    public class UserRepository : IUserRepository
    {
        private localDbContext context;

        public UserRepository(localDbContext context)
        {
            this.context = context;
        }
        public void AddUser(Users user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }

        public IEnumerable<Users> GetAllUsers()
        {
            return context.Users.AsEnumerable();
        }

        public Users GetUserById(int id)
        {
            return context.Users.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
