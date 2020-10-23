using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Humanatarian.Models;
using Microsoft.AspNetCore.Mvc;

namespace Humanatarian.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {

        private readonly LoginContext _loginContext;

        public LoginController(LoginContext loginContext)
        {
            _loginContext = loginContext;
        }

        [HttpGet]
        public IActionResult Get(string username , string password)
        {
            return NotFound();
        }
    }
}
