using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects_in_OOP
{
     class Car  // create class named as Car
    { 
        string colour = "White";  // varible Colour
    
        static void Main(string[] args)
        {
                Car myObj1 = new Car();   // Create an Object called myObj
                Car myObj2 = new Car();
                Console.WriteLine(myObj1.colour);  // used object to print the value of colour
                Console.WriteLine(myObj2.colour);
            }
        }
    }
    

