using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteAdmin.Models
{
    public class FakeDataBase 
    {
        public static List<UserData> passwords = new List<UserData>();
        public static int Id { get; set; } = 0;

        public DbSet<UserData> Passwords { get; set; }

        public static IEnumerable<UserData> GetPasswords
        {
            get{
                return passwords;
            }
        }

        public FakeDataBase() 
        {
                
        }

     
        public static void AddPassword(UserData pass)
        {
            passwords.Add(pass);
        }
        //TODO add Entity FrameWork 
        public static void GetDump(UserData pass)
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
