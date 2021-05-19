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
            while (userResponse == yes)
            {

                Console.Write("What would you like to convert to?");
                Console.ReadLine();

                string inches = null;
                string fidgetspinners = null;
                if (userResponse == inches)
                {
                    Console.Write("Enter a distance in fidget spinners: ");
                    Inch = (char)Int32.Parse(Console.ReadLine());
                    Fidget = (Inch * 3.5f);
                    Console.WriteLine("Distance in inches:" + Fidget);
                    Console.WriteLine("Would you like to convert another?");
                    Console.ReadLine();
                }

                else if (userResponse == yes)
                {
                    Console.Write("What would you like to convert to?");
                    Console.ReadLine();
                }

                else if (userResponse == fidgetspinners)
                {
                    Console.Write("Enter a distance in inches: ");
                    Inch = (char)Int32.Parse(Console.ReadLine());
                    Fidget = (char)(Inch / 3.5f);
                    Console.WriteLine("Distance in fidget spinners:" + Fidget);
                    Console.WriteLine("Would you like to convert another?");
                    Console.ReadLine();
                }

                else if (userResponse == yes)
                {
                    Console.Write("What would you like to convert to?");
                    Console.ReadLine();
                }
                else if (userResponse == feet)
                {
                    Console.Write("Enter a distance in memes: ");
                    Feet = (char)int.Parse(Console.ReadLine());
                    int Memes = Feet * 5;
                    Console.WriteLine("Distance in feet:" + Memes);
                    Console.WriteLine("Would you like to convert another?");
                    Console.ReadLine();
                }
                if (userResponse == yes)

                    Console.Write("What would you like to convert to?");
                    Console.ReadLine();
                string memes = null;
                if (userResponse == memes)
                    Console.Write("Enter a distance in inches: ");
                Inch = (char)Int32.Parse(Console.ReadLine());
                Fidget = (char)(Inch / 5);
                    Console.WriteLine("Distance in fidget spinners:" + Fidget);
                    Console.WriteLine("Would you like to convert another?");
                    Console.ReadLine();

                if (userResponse != "yes")

                    System.Environment.Exit(1);


            }

        }
    }
}

        
    


