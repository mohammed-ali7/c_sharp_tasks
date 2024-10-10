using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.classes
{
    // creating a bace class named shape
     class Shape
    {
        //method GetArea
        public void GetArea()
        {
            Console.WriteLine(0); 
        }
        Shape shape = new Shape();
        
    }
      
    class Rectangle : Shape
    {
        public void GetArea()
        {
            Console.WriteLine("rectangle is created");
        }
    }

    class circle :Shape

    {
        public void GetArea()
        {
            Console.WriteLine("circle is created");
        }
    }
    
}
