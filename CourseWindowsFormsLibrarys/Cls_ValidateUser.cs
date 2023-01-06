using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWindowsFormsLibrarys
{
    public  class Cls_ValidateUser
    {

       public bool ValidatePassword(string password)
        {
            if (password == "curso")
            {
                return true;
            }
            return false;
        }
    }
}
