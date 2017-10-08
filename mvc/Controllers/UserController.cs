
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvc.Models;
using mvc.Common;

namespace mvc.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/user/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            User user = new User();
            ReturnResult result = new ReturnResult();
            user.id = 1000+id;
            user.name = "Hello";
            user.password = "123456";
            result.ResultCode = 1;
            result.Message = "Get user successful";
            result.Content = user;
            return Json(result);
        }

        // POST api/user
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        public IActionResult Post([FromBody]User user)
        {
            System.Console.WriteLine("Hello");
            ReturnResult result = new ReturnResult();
            if (user != null)
            {
                System.Console.WriteLine("not null");
                result.Content = user;              
            }
            return Json(result);
        }

        // PUT api/user/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
