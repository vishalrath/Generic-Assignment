using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Uc2MaxxFloatValue
    {
        public static double MaxValue(double firstfloatvalue, double secondfloatvalue, double thirdfloatvalue)
        {

            if (firstfloatvalue.CompareTo(secondfloatvalue) > 0 && firstfloatvalue.CompareTo(thirdfloatvalue) > 0)
            {
                return firstfloatvalue;
            }
            else if ((secondfloatvalue.CompareTo(firstfloatvalue) > 0 && secondfloatvalue.CompareTo(thirdfloatvalue) > 0))
            {
                return secondfloatvalue;
            }
            else if ((thirdfloatvalue.CompareTo(firstfloatvalue) > 0 && thirdfloatvalue.CompareTo(secondfloatvalue) > 0))
            {
                return thirdfloatvalue;
            }
            else
            {
                return firstfloatvalue;
            }
        }
    }
}
