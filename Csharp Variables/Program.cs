using System;

namespace Csharp_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Josh";
            int age = 37;
            char gender = 'M';
            double balance = 574.29;
            decimal balance2 = 327.61m;
            bool allDataTyped = true;
            Console.WriteLine($"Hello, my name is {name}, and I am {age} years old.");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Bank of America: ${balance}");
            Console.WriteLine($"Chase: ${balance2}");
            Console.WriteLine($"{allDataTyped}");
        }
    }
}
