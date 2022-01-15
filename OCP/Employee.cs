using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class Employee
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
        public bool isManager { get; set; } = false;
        public bool isExective { get; set; } = false;
        public bool isTechnician { get; set; } = false;
    }
}
