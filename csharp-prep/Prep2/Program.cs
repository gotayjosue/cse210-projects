using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What was your grade?");
        string grade = Console.ReadLine();
        float letter = float.Parse(grade);

        if (letter >= 90)
        {
            Console.WriteLine("Your grade was A!");
            Console.WriteLine("You passed the course");
        }
        else if (letter >= 80)
        {
            Console.WriteLine("Your grade was B!");
            Console.WriteLine("You passed the course");
        }
        else if (letter >= 70)
        {
            Console.WriteLine("Your grade was C!");
            Console.WriteLine("You passed the course");
        }
        else if (letter >= 60)
        {
            Console.WriteLine("Your grade was D");
            Console.WriteLine("You have to strive yourself more");
        }
        else if (letter < 60)
        {
            Console.WriteLine("Your grade was F");
            Console.WriteLine("You have to strive yourself more");
        }


    }
}