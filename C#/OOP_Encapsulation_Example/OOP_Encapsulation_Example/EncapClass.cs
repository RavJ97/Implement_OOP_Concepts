using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Encapsulation_Example
{
    class EncapClass
    {
        private int age;
        private string name;

        //Setting age variable from program class into the private variable in EncapClass using a public method
        public void setAge(int userAge)
        {
            age = userAge;
        }

        //Returning the private variable age to the program class using a public method
        public int getAge()
        {
            return age;
        }

        //Setting name variable from program class into the private variable in EncapClass using a public method
        public void setName(string userName)
        {
            name = userName;
        }

        //Returning the private variable name to the program class using a public method
        public string getName()
        {
            return name;
        }
    }
}
