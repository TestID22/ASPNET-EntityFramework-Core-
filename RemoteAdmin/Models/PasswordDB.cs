using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteAdmin.Models
{
    public class PasswordDB : DbContext
    {
        public int PasswordDBId { get; set; }
        public DbSet<StolenPassword> StolenPasswords { get; set; }



    }
}
