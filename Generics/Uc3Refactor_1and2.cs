using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Uc3Refactor_1and2<T> where T:IComparable
    {
        public T firstvalue, secondvalue, thirdvalue;

        public Uc3Refactor_1and2(T firstvalue, T secondvalue, T thirdvalue)
        {
            this.firstvalue = firstvalue;
            this.secondvalue = secondvalue;
            this.thirdvalue = thirdvalue;
        }
        public static T Maxvalue(T firstvalue, T secondvalue, T thirdvalue)
        {

            if (firstvalue.CompareTo(secondvalue) > 0 && firstvalue.CompareTo(thirdvalue) > 0)
            {
                return firstvalue;
            }
            else if ((secondvalue.CompareTo(firstvalue) > 0 && secondvalue.CompareTo(thirdvalue) > 0))
            {
                return secondvalue;
            }
            else if ((thirdvalue.CompareTo(firstvalue) > 0 && thirdvalue.CompareTo(secondvalue) > 0))
            {
                return thirdvalue;
            }
            
        return default;
    }
     public T Maxmethod()
    {
        T max = Uc3Refactor_1and2 <T>. Maxvalue(this.firstvalue, this.secondvalue, this.thirdvalue);
        return max;
        }
    }

}
