using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_DynamicPolymorphism_Example
{
    class Chocolate : IceCream
    {
        //Constructor used here to identify when the object calls
        public Chocolate()
        {
            Console.WriteLine("Class : Chocolate");
        }

        //Same method is in IceCream class but override keyword overrides this method and calls this method
        public override void flavor()
        {
            Console.WriteLine("IceCream Type : Chocolate");
        }
    }
}
