using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteAdmin.Models
{
    public class StolenPassword
    {
        public int StolenPasswordID { get; set; }
        public string Login{ get; set; }
        public string Password { get; set; }
    }
}
