using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Random rand = new Random();

        List<int> playerA = new List<int>();
        List<int> playerB = new List<int>();

        for (int i = 0; i < 10; i++)
        {
            playerA.Add(rand.Next(0, 10));
            playerB.Add(rand.Next(0, 10));
        }

        Console.WriteLine("WELCOME To My SIMPLE GAME program.\n");

        Console.Write("Player A: ");
        foreach (int n in playerA)
            Console.Write(n + " ");

        Console.WriteLine();

        Console.Write("Player B: ");
        foreach (int n in playerB)
            Console.Write(n + " ");

        Console.WriteLine("\n");

        int match = 1;

        while (playerA.Count > 0 && playerB.Count > 0)
        {
            int a = playerA[playerA.Count - 1];
            int b = playerB[playerB.Count - 1];

            Console.WriteLine("Match " + match + ":");
            Console.WriteLine(a + " vs " + b);

            if (a > b)
            {
                playerB.RemoveAt(playerB.Count - 1);
                Console.WriteLine("Player A Win");
            }
            else if (a < b)
            {
                playerA.RemoveAt(playerA.Count - 1);
                Console.WriteLine("Player B Win");
            }
            else
            {
                playerA.RemoveAt(playerA.Count - 1);
                playerB.RemoveAt(playerB.Count - 1);
                Console.WriteLine("Rematch");
            }

            Console.WriteLine();
            match++;
        }

        Console.WriteLine("Final Result:");

        Console.Write("Player A: ");
        foreach (int n in playerA)
            Console.Write(n + " ");

        Console.WriteLine();

        Console.Write("Player B: ");
        foreach (int n in playerB)
            Console.Write(n + " ");

        Console.WriteLine("\n");

        if (playerA.Count > playerB.Count)
            Console.WriteLine("Player A Win");
        else if (playerB.Count > playerA.Count)
            Console.WriteLine("Player B Win");
        else
            Console.WriteLine("Draw");

        Console.WriteLine("\nThank you for using the program");
    }
}