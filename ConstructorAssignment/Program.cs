using System;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            const string Words = "Words here, ";//Create a const variable.
            var moreWords = "and more words here.";//Create a variable using the keyword “var.”
            Console.WriteLine(Words + moreWords);//Chain two constructors together.
        }
    }
}
