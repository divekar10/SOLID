using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class TechnicianAccount : IAccount
    {
        public Employee Create(IApplicant person)
        {
                Employee employee = new Employee();
                employee.Fname = person.Fname;
                employee.Lname = person.Lname;
                employee.Email = $"{person.Fname}{person.Lname}.tech@corp.com";
                employee.isTechnician = true;

                return employee;
            }
    }
}
