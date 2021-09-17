using System;
using System.Collections.Generic;


    class Program
    {
        static void Main()
        {
        //1st array below
        Console.WriteLine("Wwelcom to the 1st Array please select an index of the Array between 0 and 2");
        string[] stringArray1 = new string[] { "Hello", "World", "Goodbye" };//This line creates the Array and sets the values
        int UI1 = int.Parse(Console.ReadLine());// This line takes the users input and displays the corrisponding information form the list

        if (UI1 > 2)//if the user input is invalid or out of range the following will trigger
        {
            Console.WriteLine("Invalid Index Selection, skipping, Press any key to continue");// This line will display if the user make and invalid index selection
        }
        else//If the user input is withing range this will trigger
        {
            Console.WriteLine(stringArray1[UI1]);//if the usre selects and index withing range this will write the value of that index to the console
            Console.WriteLine("Press any key to continue to 2ND array.");//This line is mpre for me so i can tell where the program is at
        }
        Console.ReadLine();//This line cause the program to hold befor continuing to the next task. This is more for me to help keep track of where the program is

        //2ND array
        Console.WriteLine("Welcom to the 2ND Array please select an index of the Array between 0 and 2");
        int[] numArray1 = new int[] { 5, 2, 10 };//This line creates the Array and sets the values
        int UI2 = int.Parse(Console.ReadLine());// This line takes the users input and displays the corrisponding information form the Array


        if (UI2 > 2)
        {
            Console.WriteLine("Invalid Index Selection, skipping, Press any key to continue");// if the used selects an index out of range this message will display
        }
        else
        {
            Console.WriteLine(numArray1[UI2]);//if the usre selects and index withing range this will write the value of that index to the console
            Console.WriteLine("Press any key to continue to Lists.");//This line is more for me so i can tell where the program is at
        }
        Console.ReadLine();//This line cause the program to hold befor continuing to the next task. This is more for me to help keep track of where the program is

        //1ST List
        Console.WriteLine("Welcom to the 1ST List please select an index of the List between 0 and 1");
        List<string> intList = new List<string>();// this line craets the list 
        intList.Add("Hello");//This line \/
        intList.Add("mofo");//And this line add the strings Hello, and mofo to the list
        int UI3 = int.Parse(Console.ReadLine());// This line takes the users input and displays the corrisponding information form the list

        if (UI3 > 1)
        {
            Console.WriteLine("Invalid Index selection, skipping, Press any key to continue");// This line will display if the user make and invalid index selection
        }
        else
        {
            Console.WriteLine(intList[UI3]);
            Console.WriteLine("Thankyou for your time have a nice day - end of line.");//This line is more for me so i can tell where the program is at
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

