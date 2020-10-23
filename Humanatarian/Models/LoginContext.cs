using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Humanatarian.Models
{
    public class LoginContext : ILoginContext
    {

        private readonly LoginDatabaseContext _loginDatabase;

        public LoginContext(LoginDatabaseContext loginDatabase)
        {
            _loginDatabase = loginDatabase;
        }

        public bool IsValidLogin(LoginModel login)
        {
            return _loginDatabase.Logins.Any(cred => cred.Username.Equals(login.Username) && cred.Password.Equals(login.Password));
        }
    }
}
