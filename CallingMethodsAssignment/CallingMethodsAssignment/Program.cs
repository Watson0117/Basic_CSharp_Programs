using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CallingMethodsAssignment.MathOps;


namespace CallingMethodsAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            //MathOps MO = new MathOps.MODIV();
            Console.WriteLine("Welcome, Please pick a number!");
            string UI = Console.ReadLine();
            Console.WriteLine(UI.MODIV);
            Console.WriteLine(UI.MOMUL);
            Console.WriteLine(UI.MOADD);
            Console.WriteLine(UI.MathOps.MODIV);
        }
    }
}
