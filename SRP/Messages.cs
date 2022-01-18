using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_SRP
{
    public class Messages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome To The Application");
        }

        public static void EndApplication()
        {
            Console.WriteLine("Press enter to close....");
            Console.ReadLine();
        }

        public static void ValidationError(string fieldName)
        {
            Console.WriteLine($"Not Valid {fieldName}");
        }
    }
}
