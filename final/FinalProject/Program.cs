using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> options = new List<string>{"1. Add to cart", "2. Remove from cart", "3. Show cart", "4. Generate Bill", "5. Quit"};

        string answer = "0";

        while (answer != "5") {
            foreach (string option in options) {
                Console.WriteLine(option);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Please select an option");
            answer = Console.ReadLine();
        }
    }
}