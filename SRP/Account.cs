using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_SRP
{
    public class Account
    {
        public static void CreateUserName(User user)
        {
            Console.WriteLine($"Your Username is : {user.Fname.Substring(0, 1)}{user.Lname}");
        }
    }
}
