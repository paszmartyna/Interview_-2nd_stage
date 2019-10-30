using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.DbModel;
using WebAPI.Repository;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserRepository userRepository;

        public UsersController(IUserRepository repository)
        {
            userRepository = repository;
        }

        // GET: api/Users
        [HttpGet]
        public IEnumerable<Users> Get()
        {
            return userRepository.GetAllUsers();
        }

        // GET: api/Users/5
        [HttpGet("{id}", Name = "Get")]
        public Users Get(int id)
        {
            return userRepository.GetUserById(id);
        }

       [HttpPost]
        public void Post([FromBody] Users user)
        {
      

            userRepository.AddUser(user);
            //return user;
        }




    }
}
