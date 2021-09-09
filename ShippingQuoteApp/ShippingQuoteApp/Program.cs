using System;

namespace ShippingQuoteApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");// This line greats the customer

            Console.WriteLine("Please enter your packages weight");// this line writes the question to the console
            string PWTS = Console.ReadLine();
            int PackageWeight = Convert.ToInt32(PWTS);

            if (PackageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");// this line addes some text to make everything look better.
                System.Environment.Exit(0);
            }

            Console.WriteLine("Please enter your packages width");// this line write the question to the console
            string PWS = Console.ReadLine();// this line gets user input and store it as a string
            int PackageWidth = Convert.ToInt32(PWS);// this line converts it and stores it as an integer

            Console.WriteLine("Please enter your packages length");// this line write the question to the console
            string PLS = Console.ReadLine();// this line gets user input and store it as a string
            int PackageLength = Convert.ToInt32(PLS);// this line converts it and stores it as an integer

            Console.WriteLine("Please enter your packages height");// this line write the question to the console
            string PHS = Console.ReadLine();// this line gets user input and store it as a string
            int PackageHeight = Convert.ToInt32(PHS);// this line converts it and stores it as an integer

            int PackageDimensions = (PackageWidth * PackageLength * PackageHeight);// this line creates Packagedimensions total

            if (PackageWidth + PackageLength + PackageHeight > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");// this line addes some text to make everything look better.
                System.Environment.Exit(0);
            }

            int PackageValue = (PackageDimensions * PackageWeight);// this multplies the packages demension by the Packages weight
            int PackagePrice = (PackageValue / 100);// this take the results of Package value and divides it by 100 to get a price

            if (PackageHeight + PackageLength + PackageWidth < 50 && PackageWeight < 50)
            {
                Console.WriteLine("Your estimated total for shipping this package is:");// this line addes some text to make everything look better.
                Console.WriteLine(PackagePrice.ToString("C"));// this line takes the price and changes it to a dollor amount and writes it to the console.
            }
            else
            {
                Console.WriteLine("Your package is too big to be shipped with express. Have a good day....");
            }
    
        }

    }
}
