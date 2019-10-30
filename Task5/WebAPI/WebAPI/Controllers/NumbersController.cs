using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;


namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class NumbersController : Controller
    {


        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string GetData(int id)
        {
            return (id*2).ToString();
        }

      
    }
}
