using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_members_in_OOP
{
     class Car 
    {
        string Colour;  //field
        int maxSpeed;   //field
        static void Main(string[] args)
        {
            Car myObj = new Car();
            myObj.Colour = "White";
            myObj.maxSpeed = 200;

            Console.WriteLine(myObj.Colour);
            Console.WriteLine(myObj.maxSpeed);

        }
    }
}
