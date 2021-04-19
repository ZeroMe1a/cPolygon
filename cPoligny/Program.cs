using System;

namespace cPoligny
{
    class Program
    {
        static int ang_s(int s)
        {
            return (s - 2) * 180;
        }

        static int sid_a(int a)
        {
            return (a / 180) + 2;
        }

        static void Main()
        {
            Console.Title = "cPoligny Testing";

            Console.WriteLine("Welcome to cPoligny!" +
                "\n\n[0] Quit" +
                "\n[1] Internal Angle using Sides" +
                "\n[2] Sides using Internal Angle\n");


            Console.Write("?: ");
            int ch = Convert.ToInt32(Console.ReadLine());


            switch (ch)
            {
                case 0:
                    Environment.Exit(0);
                    break;

                case 1:
                    Console.Write("\nN° Sides: ");
                    int x = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"\nAnswer: {ang_s(x)}");

                    Console.Write("Press any key to quit...");
                    Console.ReadKey();

                    break;

                case 2:
                    Console.Write("N° Sides: ");
                    x = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"\nAnswer: {sid_a(x)}");

                    Console.Write("Press any key to quit...");
                    Console.ReadKey();

                    break;

                default:
                    Console.WriteLine("Unrecognized");

                    Console.Write("Press any key to return...");
                    Console.ReadKey();

                    Main();
                    break;

            } 
        }
    }
}
