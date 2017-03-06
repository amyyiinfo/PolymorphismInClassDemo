using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    class Shape //change the class name to fit the object you're creating!!
    {
        //parent class does not need a Main method

        //abstract means vague or general, idea or concept
        //takes from an abstract class and makes it specific later
        //cannot use abstract, cannot use override (parent is not overriding anything), must use virtual
        public virtual void Draw()
        {
            Console.WriteLine("Performing a class drawing tasks");

        }
        //static void Main(string[] args)
        //{

        //}
    }
}
