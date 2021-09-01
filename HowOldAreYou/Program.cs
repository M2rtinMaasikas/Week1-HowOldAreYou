using System;

namespace HowOldAreYou
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your name?");
            string username = Console.ReadLine();
            Console.WriteLine("hello," + username);
            Console.Read();
            Console.WriteLine("how old are you? Enter digits only:");
            int age = Int32.Parse(Console.ReadLine());
            int YearOfBirth = 2021 - age;
            Console.WriteLine($"you were born in + {YearOfBirth}");

    }    }
    
}