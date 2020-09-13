using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteAdmin.Models
{
    public class PasswordsDBContext : DbContext
    {
        public DbSet<UserData> UserDatas { get; set; } 
        public PasswordsDBContext(DbContextOptions<PasswordsDBContext> options) : base(options)
        {
                
        }
    }
}
