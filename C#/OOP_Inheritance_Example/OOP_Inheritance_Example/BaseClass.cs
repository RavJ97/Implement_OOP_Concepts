using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance_Example
{
    class BaseClass
    {
        //Declaring protected variables (Derived class can access public and protected variables)
        protected int age = 22;
        protected string name = "Ravindu";

        public void sayMyName()
        {
            Console.WriteLine("My Name is " +name);
        }
    }
}
