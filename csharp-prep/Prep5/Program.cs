using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string user_name = "";
        user_name = PromptUserName(user_name);

        int number = 0;
        number = PromptUserNumber(number);

        DisplayResult(user_name, number);

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName(string user_name)
    {
        Console.WriteLine("Please enter your name: ");
        user_name = Console.ReadLine();
        return user_name;
    }

    static int PromptUserNumber(int number)
    {
        Console.WriteLine("Please enter your favorite number");
        string user_input = Console.ReadLine();
        number = int.Parse(user_input);
        return number;
    }

    static int SquareNumber(int number)
    {
        int square_number = number * number;
        return square_number;
    }

    static void DisplayResult(string name, int number)
    {   
        Console.WriteLine($"{name}, the square of your number is {SquareNumber(number)}");
    }


}   

