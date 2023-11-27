using System;
using System.Data.SqlTypes;

class Program
{
    public static void Main()
    {
        int[] tärning1 = { 1, 2, 3, 4, 5, 6 };
        int[] tärning2 = { 1, 2, 3, 4, 5, 6 };
        int[] tärning3 = { 1, 2, 3, 4, 5, 6 };
        int[] tärning4 = { 1, 2, 3, 4, 5, 6 };
        int[] tärning5 = { 1, 2, 3, 4, 5, 6 };

        int[][] tärningar = { tärning1, tärning2, tärning3, tärning4, tärning5 };

        Console.WriteLine("Tärningarna kastas");
        Console.ReadKey();
        Tärningskast(tärningar);
    }

    public static void Tärningskast(int[][] tärningar)
    {
        int[] resultat = new int[5];
        int[] test = new int[5];
        Random slump = new Random();
        Console.WriteLine("1  2  3  4  5");

        for (int i = 0; i < tärningar.Length; i++)
        {
            test[i] = tärningar[i][slump.Next(6)];
            Console.Write($"|{test[i]}|");
        }
        Console.WriteLine("Skriv nummer på de tärningar du vill låsa in");
        string[] input = Console.ReadLine().Split(" ");
        int[] inputInt = new int[6];
        for (int i = 0;i < input.Length;i++)
        {
            inputInt[i] = int.Parse(input[i]);
        }
        for (int i = 0; i < input.Length; i++)
        {
            resultat[i] = resultat.Concat(new int[] { inputInt[i]}).ToArray();
        }
    }
}