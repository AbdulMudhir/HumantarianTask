using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Humanatarian.Models;
using Microsoft.AspNetCore.Mvc;

namespace Humanatarian.Controllers
{

    [ApiController]
    [Route("api/login")]
    public class LoginController : ControllerBase
    {

        private readonly ILoginContext _loginContext;

        public LoginController(ILoginContext loginContext)
        {
            _loginContext = loginContext;
        }

        [HttpGet]
        public IActionResult Get(string username, string password)
        {
            var login = new LoginModel() { Username = username, Password = password };


            var credentialExist = _loginContext.IsValidLogin(login);

                if (credentialExist)
                {
                    return Ok();
                }
            
            return NotFound();

        }
    }
}
