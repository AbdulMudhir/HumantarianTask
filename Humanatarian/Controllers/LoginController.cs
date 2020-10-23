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

        //api/login
        [HttpPost]
        public IActionResult Post([FromBody] LoginModel login)
        {

            if (ModelState.IsValid)
            {
                
                var credentialExist = _loginContext.IsValidLogin(login);

                if (credentialExist)
                {
                    return Ok();
                }
            }
            return NotFound();

        }
    }
}
