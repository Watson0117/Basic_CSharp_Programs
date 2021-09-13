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
                    case 42:
                        Console.WriteLine("you choose correctly");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("you choose wrong, but you can guess again");
                        Console.WriteLine("Guess a number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);

            
            while (isGuessed == true)
            {
                Console.WriteLine("The answer, is indeed 42. Altho it is meaningless because you never knew what the question was.");
                break;
            }
               
            Console.ReadLine();
        }
    }
}
