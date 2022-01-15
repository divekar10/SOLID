using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class Technician : IApplicant
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public IAccount AccountProcessor { get; set; } = new TechnicianAccount();
    }
}
