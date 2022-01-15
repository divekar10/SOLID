using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class ExecitiveAccount : IAccount
    {
        public Employee Create(IApplicant person)
        {
            Employee employee = new Employee();
            employee.Fname = person.Fname;
            employee.Lname = person.Lname;
            employee.Email = $"{person.Fname}{person.Lname}.exec@corp.com";
            employee.isManager = true;
            employee.isExective = true;

            return employee;
        }
    }
}
