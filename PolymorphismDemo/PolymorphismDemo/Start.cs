using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    class Start
    {
        static void Main(string[] args)
        {
            Shape s = new Circle(); //called from the child class and result includes printline from parent and child
            Triangle s2 = new Triangle(); //recursive function calls itself
            s.Draw();
            s2.Draw();




            Console.ReadLine(); //stops the program from crashing

            //prints
            //Drawing a Circle
            //Performing a class drawing tasks
            //Drawing a Triangle
            //Performing a class drawing tasks
        }
    }
}
