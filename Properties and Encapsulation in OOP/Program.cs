using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_and_Encapsulation_in_OOP
{
    class Person
    {
        private string name;        // Create a field
        public string Name          // property
        {
            get { return name; }
            set { name = value; }
        }
    }
    class program
    { 
        static void Main(string[] args)
        {
            Person myObj = new Person();
            myObj.Name = "Jhon";
            Console.WriteLine(myObj.Name);
        }
    }
}
