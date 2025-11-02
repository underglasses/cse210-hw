//CSE 210 | PROGRAMMING EXERCISES | MARCOS CHINGA
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();
        Console.WriteLine("Enter numbers one at a time. Type '0' when finished:");
        string input = Console.ReadLine();
        while (input != "0")
        {
            if (int.TryParse(input, out int number))
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
            input = Console.ReadLine();
        }
        if (numbers.Count > 0)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            double average = (double)sum / numbers.Count;
            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {numbers.Max()}");
            Console.WriteLine($"The smallest positive number is: {numbers.Where(n => n > 0).Min()}");
            Console.WriteLine($"The sorted list is : {string.Join(", ", numbers.OrderBy(n => n))}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}