using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_StaticPolymorphism_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            //Object created to call the methods in GetArea class
            GetArea ga = new GetArea();

            //Calling the methods using the object created
            ga.getArea(5);
            ga.getArea(10,5);

            Console.ReadLine();
        }
    }
}
