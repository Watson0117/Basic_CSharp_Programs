using System;
using System.Collections.Generic;
using System.Text;
using static MainMethodApp.MathOps;

namespace MainMethodApp
{
    // Create a class. In that class, create a method that will take in an integer,
    // create a math operation for this integer(addition, subtraction, etc.), then return
    // the answer as an integer.

    

    public class MathOps
    {
        public int MoFun(int addend)  // takes in an int and returns and int
        {
            return addend / 2;
        }
        //-------------------------------------------------------------------------------------------------------


        //Add a second method to the class with the same name that will take in a decimal,
        //create a different math operation for it, then return the answer as an integer.
        public decimal MoFun(decimal addend)  // takes in an decimal and returns and decimal
        {
            return addend * 2;
        }
        //-------------------------------------------------------------------------------------------------------


        // Add a third method to the class, with the same name, that will take in a string,
        // convert it to an integer if possible, do a different math operation to it,
        // then return the answer as an integer.
        public string MoFun(string UIS)  // takes in an string and returns and string
        {
            int Uii = Convert.ToInt32(UIS);// this converts the string enetered by the user as a integer
            int A1 = Uii + 5;
            string Uis = Convert.ToString(A1);// i had to add a way to convert it back to a string so the return wouldent have an error
            return Uis;// For so reason it was saying that it couldent convert the int back to a string so i added the line above

            //--------------------------------------------------------------------------------
        }
    }
}
