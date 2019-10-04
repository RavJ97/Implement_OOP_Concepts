using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Abstraction_Example
{
    class Program : AbstractionClass
    {
        static void Main(string[] args)
        {
            //Creating the object for the child class
            Program pm = new Program();

            //Calling the normal method using the object created
            Console.WriteLine("The Addition is " + pm.AddTwoNumbers(10, 20));

            //Calling the abstract method using the object created
            Console.WriteLine("The Multiplication is " + pm.MultiplyNumbers(10, 20));

            Console.ReadLine();
        }

        //The body of the abstract method should be coded in the class where the abstract method will be called
        public override int MultiplyNumbers(int n1, int n2)
        {
            return n1 * n2;
        }
    }
}
