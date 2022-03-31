using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismAssignment
{
    interface IQuittable//Create an interface called IQuittable
    {
        void Quit()//have it define a void method called Quit().
        {
            Console.WriteLine("You Quit dident you..?");
        }
    }
}
