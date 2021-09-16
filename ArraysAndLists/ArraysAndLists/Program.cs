using System;
using System.Collections.Generic;


    class Program
    {
        static void Main()
        {
        //11111111111111111111




        //222222222222222222222222
        Console.WriteLine("Pick an array index between 0 and 2");
        int[] numArray1 = new int[] { 5, 2, 10 };
        int index = int.Parse(Console.ReadLine());

        do
        {
            switch (index)
            {
                case 0: // 
                    Console.WriteLine(numArray1[index]);

                    break;// this line stope the program from continuing to the default

                case 1:
                    Console.WriteLine(numArray1[index]);
                    break;

                case 2:
                    Console.WriteLine(numArray1[index]);
                    break;

                default: // this line set the default output when the user chooses out of index
                    Console.WriteLine("Please choose an index between 0-2");
                    Console.WriteLine("choose an index.");// this lina write to ask the user to give another guess
                    int.Parse(Console.ReadLine());
                    break;
            }
        }
        while (index >3);
        Console.WriteLine(numArray1[index]);
        Console.WriteLine("Press any key to continue.");
        Console.ReadLine();

        //333333333333333333333333
        //Do wile loops or if else statments.

        //do
        //{
        //    switch (number)
        //    {
        //        case 42: // this sets the correct answer to 42 anthing else will give the response below
        //            Console.WriteLine("you choose correctly");
        //            isGuessed = true;// this set the answer 42 as true makeing the below wile statmnet work
        //            break;// this line stope the program from continuing to the default
        //        default: // this line set the default output when the user dosent guess correctly
        //            Console.WriteLine("you choose wrong, but you can guess again");
        //            Console.WriteLine("Guess a number.");// this lina write to ask the user to give another guess
        //            number = Convert.ToInt32(Console.ReadLine());
        //            break;
        //    }
        //}
        //while (!isGuessed);


        //444444444444444444444444
        Console.WriteLine("Pick an array index between 0 and 1");
        List<string> intList = new List<string>();
        intList.Add("Hello");
        intList.Add("mofo");
        int index2 = int.Parse(Console.ReadLine());

        if (index < 2)
        {
            Console.WriteLine(intList[index]);
        }
        else
        {
            Console.WriteLine("Please pick an index between 0-1");
            int.Parse(Console.ReadLine());
        }
        


        //    int[] numArray = new int[5];
        // numArray[0] = 5;
        // numArray[1] = 2;
        // numArray[2] = 10;
        // numArray[3] = 200;
        // numArray[4] = 5000;

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };

        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };
        //numArray2[5] = 650;
        //Console.WriteLine(numArray2[5]);
        //Console.ReadLine();

    }
    }

