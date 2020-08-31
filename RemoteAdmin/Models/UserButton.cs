using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteAdmin.Models
{
    public class UserButton
    {
        public bool isPressed = false;

        public UserButton(bool isPressed)
        {
            this.isPressed = isPressed;
        }
        public void OpenCMD()
        {
            if(isPressed == true)
            {
                Process.Start("cmd");
            }
        }
    }
}
