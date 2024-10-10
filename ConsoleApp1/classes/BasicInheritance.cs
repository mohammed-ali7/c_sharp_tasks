using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.classes
{


    using System;

    // single inheritance
    class BasicInheritance
    {
       
        //Create a base class called Vehicle with properites
        public class Vehicle
        {
            //properties like Make, Model, and Year

            public string Make = "japan";
            public string Model = "Nisan";
            public string Year = " 1992";

            // Adding a method DisplayInfo() in Vehicle to display the details of the vehicle
            public virtual string DisplayInfo()
            {
                string msg = Make;
                Console.WriteLine(msg);
                return msg;
            }
        }
        //create two derived classes, Car and Truck
        public class Car : Vehicle
        {
            public new void DisplayInfo()
            {
                Console.WriteLine(Make + Model + Year);
            }
        }
        public class Truck : Vehicle
        {
            public new void DisplayInfo()
            {

                Console.WriteLine(Make + Model + Year);
            }
        }
    }
}
