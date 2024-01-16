using System;

class Program
{
    static void Main(string[] args)
    {
        int guess_number = 0;

        // Console.WriteLine("What is the magic number?");
        // string magic_number = Console.ReadLine();
        // int number = int.Parse(magic_number);

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        
        while (number != guess_number)
        {
            Console.WriteLine("What is your guess?");
            string guess = Console.ReadLine();
            guess_number = int.Parse(guess);

            if (guess_number > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess_number < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess_number == number)
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}