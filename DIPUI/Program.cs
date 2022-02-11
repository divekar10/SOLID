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
            IPerson owner = Factory.CreatePerson();

            owner.FirstName = "Akash"; 
            owner.lastName = "Divekar";
            owner.PhoneNumber = "7875200959";
            owner.EmailAddres = "akash@nimapinfotech.com";


            IChore chore = Factory.CreateChore();

            chore.ChoreName = "Take out the trash";
            chore.Owner = owner;
            

            chore.PerformedWork(3);
            chore.PerformedWork(1.5);
            chore.CompleteChore();

            Console.ReadLine();
        }
    }
}
