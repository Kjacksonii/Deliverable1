using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            char Feet;
            double Fidget;
            char Inch;
            string userResponse = null;
            string feet = null;
            string yes = null;
            string memes = null;
            string fidgetspinners = null;
            do
            {

                Console.Write("What would you like to convert to?");
                Console.ReadLine();

                string inches = null;
                if (userResponse == inches)
                {
                    Console.Write("Enter a distance in fidget spinners: ");
                    Inch = (char)Int32.Parse(Console.ReadLine());
                    Fidget = (Inch * 3.5f);
                    Console.WriteLine("Distance in inches:" + Fidget);
                    Console.WriteLine("Would you like to convert another?");
                    Console.ReadLine();
                }
                if (userResponse == yes)
                {
                    Console.Write("What would you like to convert to?");
                    Console.ReadLine();
                }

                if (userResponse == fidgetspinners)
                {
                    Console.Write("Enter a distance in inches: ");
                    Inch = (char)int.Parse(Console.ReadLine());
                    Fidget = (char)(Inch / 3.5f);
                    Console.WriteLine("Distance in fidget spinners:" + Fidget);
                    Console.WriteLine("Would you like to convert another?");
                    Console.ReadLine();
                }

                if (userResponse == yes)
                {
                    Console.Write("What would you like to convert to?");
                    Console.ReadLine();
                }
                if (userResponse == feet)
                {
                    Console.Write("Enter a distance in Memes: ");
                    Feet = (char)int.Parse(Console.ReadLine());
                    int Memes = Feet * 5;
                    Console.WriteLine("Distance in Memes:" + Memes);
                    Console.WriteLine("Would you like to convert another?");
                    Console.ReadLine();
                }
                if (userResponse == yes)
                {
                    Console.WriteLine("What would you like to convert to?");
                    Console.ReadLine();

                }
                if (userResponse == memes)
                {
                    Console.Write("Enter a distance in feet: ");
                    char mem = (char)int.Parse(Console.ReadLine());
                    int meme = (char)(mem / 5);
                    Console.WriteLine("Distance in memes:" + meme);
                    Console.WriteLine("Would you like to convert another?");
                    Console.ReadLine();
                }

            } while (userResponse != yes);
            {
                Console.WriteLine();
                System.Environment.Exit(1);
            }
        }


    }

}