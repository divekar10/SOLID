using System;

namespace Solid_SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            Messages.WelcomeMessage();

            User user = UserData.GetData();

            //Checking validation
            bool isDataValid = UserValidate.Validate(user);

            if (!isDataValid)
            {
                return;
            }
            //creating username

            Account.CreateUserName(user);
            Messages.EndApplication();

        }
    }
}
