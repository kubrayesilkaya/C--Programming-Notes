using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Class
{
    partial class People
    {
        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }

        public string GetEmail(int peopleId)
        {
            string result = string.Empty;
            if (peopleId > 0)
            {
                result = this.Email;
            }
            else
            {
                result = "Email is not found";
            }
            return result;
        }
    }
}
