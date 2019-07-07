using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Abstraction_Example
{
    abstract class AbstractionClass
    {
        //abstract methods can only be defined in the abstract class (can't add body here)
        public abstract int MultiplyNumbers(int n1, int n2);

        //Abstract classes can also have normal methods
        public int AddTwoNumbers(int n1, int n2)
        {
            return n1 + n2;
        }
    }
}
