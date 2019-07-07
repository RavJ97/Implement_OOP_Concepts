using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Encapsulation_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable declaration
            int age;
            string name;

            //Object made to call the Encapsulation Class
            EncapClass ec = new EncapClass();

            //User inputs taken for name and age
            Console.WriteLine("Enter Your Name ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Your Age ");
            age = int.Parse(Console.ReadLine());

            //Setting the name and age variable to the private variables in the Encapsulation Class
            //Calling the methods using the object created to set the values to the private variables
            ec.setAge(age);
            ec.setName(name);

            //Printing the private variables in Encapsulation Class
            //Calling the methods using the object created to get the values from the private variables
            Console.WriteLine("Your Name is " + ec.getName());
            Console.WriteLine("Your Age is " + ec.getAge());

            Console.ReadLine();
        }
    }
}
