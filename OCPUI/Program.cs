using OCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IApplicant> applicants = new List<IApplicant>
            {
                new Person {Fname = "Akash", Lname = "Divekar" },
                new Manager {Fname = "Pranay", Lname = "Shinde"},
                new Executive {Fname = "Ajay", Lname = "Kumavat" },
                new Technician {Fname = "Dhanashree", Lname = "Kolaskar" }
            };

            List<Employee> employees = new List<Employee>();

            foreach (var person in applicants)
            {
                employees.Add(person.AccountProcessor.Create(person));
            }

            Console.WriteLine("Employee Details");

            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.Fname} {emp.Lname} :({emp.Email.ToLower()}) \nIsManager : {emp.isManager}\nIsExecutive : {emp.isExective}\nIsTechnicain : {emp.isTechnician}\n" );
            }

            Console.ReadLine();
        }
    }
}
