// Created by: Johanna Liu
// Created on: Mar 2022
//
// This program does basic math
using System;

class Program
{
    public static void Main(string[] args)
    {
        int counter;
        var answer = 0;

        //Input 
        Console.WriteLine("This program multiplies two numbers using loops.");
        Console.WriteLine("");
        Console.Write("Enter a number: ");
        counter = Convert.ToInt32(Console.ReadLine());

        //Process
        for (int addedNumber = 1; addedNumber <= counter; addedNumber++)
        {
            answer += addedNumber;
        }

        Console.WriteLine("The sum is: " + answer);

        Console.WriteLine("\nDone.");
    }
}

