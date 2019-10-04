using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_DynamicPolymorphism_Example
{
    class IceCream
    {
        //Constructor used here to identify when the object calls
        public IceCream()
        {
            Console.WriteLine("Class : Icecream");
        }

        //Same method is in Chocolate class but virtual keyword avoids this method from being called
        public virtual void flavor()
        {
            Console.WriteLine("IceCream Type : Vanilla");
        }
    }
}
