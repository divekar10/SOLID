using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_SRP
{
    public class UserValidate
    {
        public static bool Validate(User user)
        {
            if (string.IsNullOrWhiteSpace(user.Fname))
            {
                Messages.ValidationError("First Name");
                return false;
            }

            if (string.IsNullOrWhiteSpace(user.Lname))
            {
                Messages.ValidationError("Last Name");
                return false;
            }
            return true;
        }
    }
}
