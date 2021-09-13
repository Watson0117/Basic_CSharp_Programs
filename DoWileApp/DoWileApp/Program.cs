using System;

namespace DoWileApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is the Answer to the Ultimate Question of Life, The Universe, and Everything? Guess a number.");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 42;

            do
            {
                switch (number)
                {
                    case 42: // this sets the correct answer to 42 anthing else will give the response below
                        Console.WriteLine("you choose correctly");
                        isGuessed = true;// this set the answer 42 as true makeing the below wile statmnet work
                        break;// this line stope the program from continuing to the default
                    default: // this line set the default output when the user dosent guess correctly
                        Console.WriteLine("you choose wrong, but you can guess again");
                        Console.WriteLine("Guess a number.");// this lina write to ask the user to give another guess
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);

            
            while (isGuessed == true)// when the answer is 42 this will trigger
            {
                Console.WriteLine("The answer, is indeed 42. Although it is meaningless because you never knew what the question was.");
                break;
            }
               
            Console.ReadLine();//this keeps the app open
        }
    }
}
