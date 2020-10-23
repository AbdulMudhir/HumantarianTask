using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Humanatarian.Models
{
    public class LoginDatabaseContext:DbContext
    {
        public LoginDatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<LoginModel> Logins { get; set; }
    }
}
