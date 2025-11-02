//CSE 210 | PROGRAMMING EXERCISES | MARCOS CHINGA101
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was your grade?: ");
        string valueFromUser = Console.ReadLine();

        int grade = int.Parse(valueFromUser);
        if (grade >= 90)
        {
            string textVersion = "A";
            Console.WriteLine($"Your letter grade is: {textVersion}.");
        }
        else if (grade >= 80)
        {
            string textVersion = "B";
            Console.WriteLine($"Your letter grade is: {textVersion}.");
        }
        else if (grade >= 70)
        {
            string textVersion = "C";
            Console.WriteLine($"Your letter grade is: {textVersion}.");
        }
        else if (grade >= 60)
        {
            string textVersion = "D";
            Console.WriteLine($"Your letter grade is: {textVersion}.");
        }
        else if (grade <= 59)
        {
            string textVersion = "F";
            Console.WriteLine($"Your letter grade is: {textVersion}.");
        }
        else
        {
            string textVersion = "Value does not correspond to any letter grade.";
            Console.WriteLine($"Your letter grade is: {textVersion}.");
        }
    }
}