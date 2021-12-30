using System;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            myConstClass obj = new myConstClass();
        }
        public class myConstClass
        {
            public myConstClass() : this(10)
            {
                var moreWords = "1347 is 1337 plus 10";//Create a variable using the keyword “var.”// No parameter constructor method.// First Constructor  
                Console.WriteLine(moreWords);//Chain two constructors together.
            }
            public myConstClass(int num)
            {
                int num2 = num;
                const int leet = 1337;//Create a const variable.
                int leetPlusNum = leet + num;
                Console.WriteLine(leetPlusNum);//Chain two constructors together.// Constructor with one parameter.// Second Constructor}  
            }
        }
    }
}
