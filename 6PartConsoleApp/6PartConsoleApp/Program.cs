using System;
using System.Collections.Generic;

namespace _6PartConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Jesse", "Erik", "Daniel", "Adam" };
            Console.WriteLine("enter text");
            string input = Console.ReadLine();

            for (int j = 0; j < names.Length; j++)
            {
                names[j] = names[j] + input;
            }

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();

            ////------------------------------------------------infinite loop
            Console.WriteLine("infinite Loop");
            int[] numbers = { 1, 2, 3, 4 };
            while (numbers[1] < 5)// as al the number in the array are less than 5 this loop would run indefinetly without the break on line 31 
            {
                Console.WriteLine(numbers[3]);
                break;// withiout this line the code will create an infinite loop
            }
            Console.ReadLine();
            //------------------------------------------------< loop
            Console.WriteLine("< Loop");
            int[] numbers2 = { 1, 2, 3, 66 };
            while (numbers2[1] < 5)
            {
                Console.WriteLine(numbers2[3]);// this uses the < to make the loop and will run as londg as the number in the 1 index is less than 5 in this case 2
                break;// withiout this line the code will create an infinite loop
            }
            Console.ReadLine();
            //------------------------------------------------<= loop
            Console.WriteLine("<= Loop");
            int[] numbers3 = { 1, 2, 3, 77 };
            while (numbers3[1] <= 2)// this uses the <= to make the loop it will run as long as 2 is less than or equal to the number in the 1 index in this case 2
            {
                Console.WriteLine(numbers3[3]);
                break;// withiout this line the code will create an infinite loop
            }


            //////---------------------------------------------------------List part 4
            Console.WriteLine("List of names section");
            List<string> Snames = new List<string>() { "Jesse", "Eric", "Adam", "Daniel" };
            string UISname = Console.ReadLine();
            foreach (string Sname in Snames)
            {
                if (UISname == "Jesse")
                {
                    Console.WriteLine(Snames[0]);// depending on what the user typed they will get the corrisponding string in that index.
                    Console.WriteLine("Index 0 ");
                    break;
                }
                if (UISname == "Eric")
                {
                    Console.WriteLine(Snames[1]);// depending on what the user typed they will get the corrisponding string in that index.
                    Console.WriteLine("Index 1 ");
                    break;
                }
                if (UISname == "Adam")
                {
                    Console.WriteLine(Snames[2]);// depending on what the user typed they will get the corrisponding string in that index.
                    Console.WriteLine("Index 2 ");
                    break;
                }
                if (UISname == "Daniel")
                {
                    Console.WriteLine(Snames[3]);// depending on what the user typed they will get the corrisponding string in that index.
                    Console.WriteLine("Index 3 ");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid");
                    break;
                }
            }
            ////// part 5 ------------------------------------------

            Console.WriteLine("List of names section 2");
            List<string> Hnames = new List<string>() { "Adam", "Eric", "Adam", "Daniel" };
            string UIHname = Console.ReadLine();
            foreach (string Hname in Hnames)
            {
                if (UIHname == "Eric")
                {
                    Console.WriteLine(Hnames[1]);// depending on what the user typed they will get the corrisponding string in that index.
                    Console.WriteLine("Index 1 ");
                    break;
                }
                if (UIHname == "Adam")
                {
                    Console.WriteLine(Hnames[2]);// depending on what the user typed they will get the corrisponding string in that index.
                    Console.WriteLine("Index 0 ");
                    Console.WriteLine("Index 2 ");
                    break;
                }
                if (UIHname == "Daniel")
                {
                    Console.WriteLine(Hnames[3]);// depending on what the user typed they will get the corrisponding string in that index.
                    Console.WriteLine("Index 3 ");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid");
                    break;
                }
            }
            //part 6 -----------------------------------

            Console.WriteLine("List of names section 3");
            Console.ReadLine();
            {
                List<string> mnamelist = new List<string>();
                mnamelist.Add(new string("Eric"));
                mnamelist.Add(new string("Adam"));
                mnamelist.Add(new string("Adam"));
                
               
                List<string> mnamelist2 = new List<string>();
                mnamelist2.Add(new string("Adam"));
               
                
               foreach (string mname in mnamelist)
                {
                    if (mnamelist.Contains(mnamelist2[0]))
                    {
                        Console.WriteLine("That Name is already exists please try again");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Name has be added.");
                        mnamelist.Add(mnamelist2[0]);
                    }
                }
                

                
            }

            Console.ReadLine();
        }
    }
}
