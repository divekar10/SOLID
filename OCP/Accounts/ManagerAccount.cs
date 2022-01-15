using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class ManagerAccount : IAccount
    {
        public Employee Create(IApplicant person)
        {
            Employee employee = new Employee();
            employee.Fname = person.Fname;
            employee.Lname = person.Lname;
            employee.Email = $"{person.Fname}{person.Lname}.man@corp.com";

            employee.isManager = true;

            return employee;
        }
    }
}
