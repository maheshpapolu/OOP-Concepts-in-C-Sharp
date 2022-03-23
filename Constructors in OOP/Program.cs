using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_in_OOP
{
    class Car                                   // Create a car class
    {
        public string model;                    // create a field

        public Car()                            // create a class constructor for the car class
        {
            model = "Mustang";                  // set the initial value for model
        }
        static void Main(string[] args)
        {
            Car Ford = new Car();               // call the constructor

            Console.WriteLine(Ford.model);     // Print the value of model
        }
    }
}
