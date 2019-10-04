using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_DynamicPolymorphism_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            //Child class object is created to call methods from both parent class and child class
            Chocolate ch = new Chocolate();

            //There are 2 methods with the same name and parameters in parent class and child class
            //Virtual keyword in parent class method avoids it from running
            //Override keyword in child class method makes it run
            ch.flavor();

            Console.ReadLine();
        }
    }
}
