using LSP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IManager accountingVP = new Manager();

            accountingVP.FirstName = "Akash";
            accountingVP.LastName = "Divekar";
            accountingVP.CalculatePerHourRate(4);

            IManaged emp = new Employee();

            emp.FirstName = "John";
            emp.LastName = "Mayer";
            emp.AssignManager(accountingVP);
            emp.CalculatePerHourRate(2);

            Console.WriteLine($"{emp.FirstName}'s salary is ${emp.Salary}/hour \nAssigned Manager is : {accountingVP.FirstName} {accountingVP.LastName}");

            Console.ReadLine();
        }
    }
}
