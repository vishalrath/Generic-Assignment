using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Uc4GenericMethod<T> where T : IComparable
    {
        T[] arrName; // array declaration
        public Uc4GenericMethod(T[] arrName)  //constructer to intialize to generic
        {
            this.arrName = arrName;
        }
        public T[] sortMethod(T[] values)           //user difune generic method by using array.short() method
        {
            Array.Sort(values);             // Array.short method
            return values;
        }
        public T MaxValue(params T[] ar)
        {
            var sortValue = sortMethod(ar);
            return sortValue[^1];
        }
        public T MaxMethod()
        {
            var max = MaxValue(this.arrName);
            return max;
        }
        public void printMaxValue()
        {
            var max = MaxValue(this.arrName);
            Console.WriteLine("\nmaximum Array value is:" + max);
        }

    }
}
