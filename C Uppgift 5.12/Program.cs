using System;
using System.Data.SqlTypes;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        try
        {
            int[] tärningar = { 0, 0, 0, 0, 0};

            Console.WriteLine("Tärningarna kastas");
            Console.ReadKey();
            while (tärningar.Contains(0))
            {
                Tärningskast(tärningar);
            }

            Console.WriteLine("Dina tärningar:");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            foreach (int tärning in tärningar)
            {
                Console.Write($"|{tärning}|");
            }
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine();
            Console.WriteLine("Tack för att du har spelat!");
            Console.WriteLine("Vill du spela igen? (y/n)");
            string svar = Console.ReadLine();

            if (svar == "y")
            {
                Main();
            }
            else 
            {
                Environment.Exit(0);
            }
        }
        catch
        {
            Console.WriteLine("Något gick fel, försök igen");
            Main();
        }
    }

    public static void Tärningskast(int[] tärningar)
    {
        int[] test = new int[5];
        Random slump = new();
        Console.WriteLine(" 1  2  3  4  5");

        for (int i = 0; i < test.Length; i++)
        {
            test[i] = slump.Next(1, 7);
        }

        for (int i = 0; i < test.Length; i++)
        {
            if (tärningar[i] != 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"|{tärningar[i]}|");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.Write($"|{test[i]}|");
            }
        }
        Console.WriteLine();

        Console.WriteLine("Skriv nummer på de tärningar du vill låsa in");
        string[] input = Console.ReadLine().Split(" ");

        int[] inputInt = new int[input.Length];
        for (int i = 0;i < input.Length;i++)
        {
            inputInt[i] = int.Parse(input[i]);
        }

        for (int i = 0; i < input.Length; i++)
        {
            tärningar[inputInt[i] - 1] = test[inputInt[i] - 1];
        }
    }
}