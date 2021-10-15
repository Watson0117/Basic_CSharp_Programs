using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CallingMethodsAssignment.MathOps;


namespace CallingMethodsAssignment
{
    public static class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome, Please pick a number!");// this line help me keep track of where the program is at
            string UIS = Console.ReadLine();
            int UII = Convert.ToInt32(UIS);

            
            int CUDIV = MathOps.MODIV(UII);// this line calle the method MODIV that is a part of the class MathOps
            int CUMUL = MathOps.MOMUL(UII);// this line calle the method MOMUL that is a part of the class MathOps
            int CUADD = MathOps.MOADD(UII);// this line calle the method MOADD that is a part of the class MathOps

            // this line below help me keep track of where the program is at
            Console.WriteLine("You picked the number " + UII + " This number will be Divided by 2, then multiplied by 2, and then have 500 added to it");
            Console.WriteLine(CUDIV);//This line writes the value of CUDIV
            Console.WriteLine(CUMUL);//This line writes the value of CUMUL
            Console.WriteLine(CUADD);//This line writes the value of CUADD
        }
    }
}
