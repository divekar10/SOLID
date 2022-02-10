using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public class Person : IPerson
    {
        public string FirstName { get; set; }
        public string lastName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddres { get; set; }
    }
}
