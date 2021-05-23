using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            double Feet;
            decimal Fidget, Memes;
            double Inch;
            Console.WriteLine("Would you like to convert?");
            
            string userResponse = Console.ReadLine().ToLower();

            while (userResponse == "yes")
            {
                Console.WriteLine("What would you like to convert to?");
                userResponse = Console.ReadLine().ToLower();

                if (userResponse == "inches")
                {
                    Console.Write("Enter a distance in fidget spinners: ");
                    Inch = (double)decimal.Parse(Console.ReadLine());
                    Fidget = ((decimal)(Inch * 3.5f));
                    Console.WriteLine("Distance in inches:" + Fidget);
                    Console.WriteLine("Would you like to convert another?");
                    userResponse = Console.ReadLine();
                }

                else if (userResponse == "fidget spinners")
                {
                    Console.Write("Enter a distance in inches: ");
                    Inch = (double)decimal.Parse(Console.ReadLine());
                    Fidget = (decimal)(Inch / 3.5f);
                    Console.WriteLine("Distance in fidget spinners:" + Fidget);
                    Console.WriteLine("Would you like to convert another?");
                    userResponse = Console.ReadLine();
                }

                else if (userResponse == "feet")
                {
                    Console.Write("Enter a distance in memes: ");
                    Feet = (double)decimal.Parse(Console.ReadLine());
                    Memes = (decimal)(Feet / 5f);
                    Console.WriteLine("Distance in feet:" + Memes);
                    Console.WriteLine("Would you like to convert another?");
                    userResponse = Console.ReadLine();
                }

                else if (userResponse == "memes")
                {
                    Console.Write("Enter a distance in feet: ");
                    double mem = (double)decimal.Parse(Console.ReadLine());
                    decimal meme = (decimal)(mem * 5f);
                    Console.WriteLine("Distance in memes:" + meme);
                    Console.WriteLine("Would you like to convert another?");
                    userResponse = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine();
                    System.Environment.Exit(1);
                }
            }
        }


    }

}