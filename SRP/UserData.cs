using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_SRP
{
    public class UserData
    {
        public static User GetData()
        {
            User user = new User();

            //Taking user input
            Console.WriteLine("First Name : ");
            user.Fname = Console.ReadLine();

            Console.WriteLine("Last Name : ");
            user.Lname = Console.ReadLine();

            return user;

        }
    }
}
