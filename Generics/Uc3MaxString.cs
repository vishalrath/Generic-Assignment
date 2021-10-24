using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Uc3MaxString
    {
        public static string MaximumString(string firststring, string secondstring, string thirdstring)
        {

            if (firststring.CompareTo(secondstring) > 0 && firststring.CompareTo(thirdstring) > 0)
            {
                return firststring;
            }
            else 
            
            if ((secondstring.CompareTo(firststring) > 0 && secondstring.CompareTo(thirdstring) > 0))
            {
                return secondstring;
            }
            else if ((thirdstring.CompareTo(firststring) > 0 && thirdstring.CompareTo(secondstring) > 0))
            {
                return thirdstring;
            }
            else
            {
                return firststring;
            }
        }
    }
}
