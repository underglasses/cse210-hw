//CSE 210 | PROGRAMMING EXERCISES | MARCOS CHINGA
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        void DisplayWelcome(ref string userName)
        {
            Console.Write("What's your name?: ");
            userName = Console.ReadLine();
        }
        DisplayWelcome(userName);
    }
}