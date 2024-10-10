using ConsoleApp1.classes;
using ConsoleApp1.functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.classes.BasicInheritance;


namespace ConsoleApp1
{
    public class Program
    {

        public async static Task Main(string[] args)
        {
            Dog myDog = new Dog(); // Create a dog object
            myDog.makeSound();  // Call the abstract method

            Cat myCat = new Cat(); // Create a cat object
            myCat.makeSound();  // Call the abstract method

            Vehicle myvehicle = new Vehicle();
            myvehicle.DisplayInfo();

            Car mycar = new Car();
            mycar.DisplayInfo();

            Truck myTruck = new Truck();
            myTruck.DisplayInfo();

            var simpleFunction = new SimpleFunction();
            simpleFunction.RunExample();

            var rectangleArea = new RectangleArea();
            rectangleArea.RunExample();

            var messagePrinter = new MessagePrinter();
            messagePrinter.RunExample();

            var multipleReturns = new MultipleReturns();
            multipleReturns.RunExample();

            var advancedFunctions = new AdvancedFunctions();

            await advancedFunctions.RunExampleAsync();

                Console.ReadLine();
          
        }
    }
}
