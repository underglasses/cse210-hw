//CSE 210 | PROGRAMMING EXERCISES | MARCOS CHINGA
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Guess the number!");
        string response = "";
        Console.Write("What is the magic number?: ");
        int number = int.Parse(Console.ReadLine());
        while (response != number.ToString())
        {
            Console.Write("Enter a number: ");
            response = Console.ReadLine();

            if (response == number.ToString())
            {
                Console.WriteLine("You guessed it!");
            }
            else if (int.Parse(response) < number)
            {
                Console.WriteLine("Lower");
            }
            else if (int.Parse(response) > number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }

        Console.WriteLine("Second round! a random number has been generated. Try to guess it!");
        response = "";
        Random randomGenerator = new Random();
        number = randomGenerator.Next(1, 100);
        while (response != number.ToString())
        {
            Console.Write("Enter a number: ");
            response = Console.ReadLine();

            if (response == number.ToString())
            {
                Console.WriteLine("You guessed it!");
            }
            else if (int.Parse(response) < number)
            {
                Console.WriteLine("Lower");
            }
            else if (int.Parse(response) > number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }

    }
}