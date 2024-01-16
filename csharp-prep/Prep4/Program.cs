using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int number = 1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();

        while (number !=0)
        {
            Console.WriteLine("Enter a number:");
            string user_input = Console.ReadLine();
            number = int.Parse(user_input);

            numbers.Add(number);
        }
    
       
        var sum = numbers.Sum();
        var average = numbers.Average();
        int list_max = numbers.Max();
        Console.WriteLine($"The sum is {sum}");  
        Console.WriteLine($"The Average is {average}");
        Console.WriteLine($"The largest number is {list_max}");
            
        

            


    }
}