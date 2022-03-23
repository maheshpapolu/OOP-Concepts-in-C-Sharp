using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    // Abstract class
    abstract class Animal
    {
        // Abstract method (does not have a body)
        public abstract void animalSound();
        // Regular method
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    // Derived class (inherit from Animal)
    class Dog: Animal
    {
        public override void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The Dog says: Bow Bow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();  // Create a Pig object
            myDog.animalSound();
            myDog.sleep();
        }
    }
}