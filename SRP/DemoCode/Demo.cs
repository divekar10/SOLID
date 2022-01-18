//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Solid_SRP.DemoCode
//{
//    public class Demo
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Welcome To The Application");

//            User user = new User();

//            //Taking user input
//            Console.WriteLine("First Name : ");
//            user.Fname = Console.ReadLine();

//            Console.WriteLine("Last Name : ");
//            user.Lname = Console.ReadLine();

//            if (string.IsNullOrWhiteSpace(user.Fname))
//            {
//                Messages.ValidationError("First Name");
//                return;
//            }

//            if (string.IsNullOrWhiteSpace(user.Lname))
//            {
//                Messages.ValidationError("Last Name");
//                return;
//            }

//            Console.WriteLine($"Your Username is : {user.Fname.Substring(0, 1)}{user.Lname}");
//        }
//    }
//}
