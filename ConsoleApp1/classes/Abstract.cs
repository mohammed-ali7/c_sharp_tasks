using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.classes
{
    // Abstract class
    public abstract class Abstract
    {
        // Abstract method (does not have a body)
        public abstract void makeSound();
        // Regular method
    }

    // Derived class (inherit from Abstract)
    public class Dog : Abstract
    {
        public override void makeSound()
        {
            // The body of makeSound() is provided here
            Console.WriteLine("barking");
        }
    }

    // Separate class for Cat, also inheriting from Abstract
    public class Cat : Abstract
    {
        public override void makeSound()
        {
            // The body of makeSound() is provided here
            Console.WriteLine("meow");
        }
    }
}