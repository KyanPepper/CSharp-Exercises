﻿using ConsoleBST;
internal class Program
{
    private static void Main(string[] args2)
    {
        // Arrange / Setup
        BST tree = new BST();
        Random rnd = new Random();
        Console.WriteLine("(1) for Insert 100 Nums Followed By Space Or (2) for Rand Generate");
        string UserI = Console.ReadLine();

        if (UserI != "1" && UserI != "2")
        {
            Console.WriteLine("Follow Directions");
            throw new Exception("Follow Directions");
        }

        //Rand or User Input
        if (UserI == "1")
        {
            Console.WriteLine("Type Your Nums max 100 each followed by space");
            UserI = Console.ReadLine();
            List<int> nums = UserI.Split(" ").Select(int.Parse).ToList();
            foreach (int i in nums)
            {
                tree.Insert(i);
            }
        }
        else
        {
            for (int i = 0; i <= 100; i++)
            {
                int randnum = rnd.Next(0, 100);
                tree.Insert(randnum);
            }
        }

        //Print Statements
        tree.InOrderTrav();
        Console.WriteLine("\nTree Count:" + tree.Count());
        Console.WriteLine("\nLevels: " + tree.Levels());
        Console.WriteLine("\nMinimum Levels: " + tree.minHeight());
    }
}