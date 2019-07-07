using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_StaticPolymorphism_Example
{
    class GetArea
    {
        //In static polymorphism there can be "n" number of methods with the same name, but each should have a different set of parameters
        public void getArea(int x)
        {
            Console.WriteLine("The Area of the Square : " + x * x);
        }
        public void getArea(int x, int y)
        {
            Console.WriteLine("The Area of the Rectangle : " + x * y);
        }
    }
}
