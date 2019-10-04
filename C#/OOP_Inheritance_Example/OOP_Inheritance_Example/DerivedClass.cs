using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance_Example
{
    class DerivedClass : BaseClass
    {
        public void sayMyAge()
        {
            //age variable is accessible from the DerivedClass as the variable is declared in it's parent class(BaseClass)
            Console.WriteLine("My Age is " + age);
        }
    }
}
