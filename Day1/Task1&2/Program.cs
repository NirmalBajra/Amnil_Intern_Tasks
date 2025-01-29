using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> NumList = new List<int>();
        NumList.AddRange(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

        Console.WriteLine("Even Numbers are:");
        foreach (var num in NumList)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine("\n Task 2:");
        List<int> numbers = new List<int> { 22, 11, 44, 55, 21, 45, 62, 45, 21 };
        var max = numbers[0];
        var min = numbers[0];

        for (int i = 0; i < numbers.Count; i++)
        {
            if (max > numbers[i])+
            {
                max = numbers[i];
            }
            if (min < numbers[i])
            {
                min = numbers[i];
            }
        }
        Console.WriteLine("Maximum Number is: " + max);
        Console.WriteLine("Minimum Number is: " + min);
        Console.ReadKey();
    }
}