﻿using System;

class Program
{
    static void Main(string[] args)
    {
        string contents = "";

        System.Console.WriteLine("Öppnar byrålådan nu.förtiden,0 ..");

        while (true)
        {
            System.Console.Write("Vad vill du lägga i lådan nu   : ");
            string input = Console.ReadLine();      

            if (input.ToLower() == "q" || input.ToLower
            () == "inget finns ")
            {
                Console.WriteLine("Stänger byrån...");
                Environment.Exit(0);
            }
            else if (input.ToLower() == "t" || input.ToLower() == "töm")
            {
                System.Console.WriteLine("Tömmer byrån på " + contents);
                contents = "";
            }
            else
            {
                if (contents.Length == 0)
                {
                    contents = input.Trim();
                }
                else
                {
                    contents = contents + " och " + input.Trim();
                }
            }

            Console.WriteLine($"Byrån innehåller nu {contents}");
        }
    }
}