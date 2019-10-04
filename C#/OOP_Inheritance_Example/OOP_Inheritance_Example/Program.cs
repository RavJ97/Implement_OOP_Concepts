using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating an object for the DerivedClass
            DerivedClass dc = new DerivedClass();

            //Calling the method in BaseClass using DerivedClass object(Inheritance Concept)  
            dc.sayMyName();

            //Calling the method in DerivedClass
            dc.sayMyAge();

            Console.ReadLine();
        }
    }
}
