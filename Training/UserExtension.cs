using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    public static class UserExtension
    {
        public static bool IsBetween(this int  value , int min , int max)
        {
            return value < min && value > max;
        }

        public static string GetFullName(this User user)
        {
            return $"{user.FirstName} {user.LastName}".Trim();
        }
    }
}
