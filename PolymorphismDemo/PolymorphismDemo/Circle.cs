using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    class Circle : Shape //in java this would be "public class Circle extends Shape"
    {
        //needs to override because without is shadowing
        //need to go back to the parent class and add virtual, abstract, or override if program can be overrided 
        public override void Draw() 
        {
            Console.WriteLine("Drawing a Circle");
            //if you forgot the name of the class you are deriving from
            base.Draw(); //call the function
            //Shape.Draw(); if you know that name of the class
        }
    }
}
