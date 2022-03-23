using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_method_in_OOP
{
     class Car
    { 
        string color;                 // field
        int maxSpeed;                 // field
        public void fullThrottle()    // method
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
        static void Main(string[] args)
        {
            Car myObj = new Car();
            myObj.fullThrottle();  // Call the method
        }
    }
}
