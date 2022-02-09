using DIP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Person owner = new Person()
            {
                FirstName = "Akash",
                lastName = "Divekar",
                PhoneNumber = "7875200959",
                EmailAddres = "akash@nimapinfotech.com"
            };

            Chore chore = new Chore()
            {
                ChoreName = "Take out the trash",
                Owner = owner
            };

            chore.PerformedWork(2);
            chore.PerformedWork(1.5);
            chore.CompleteChore();

            Console.ReadLine();
        }
    }
}
