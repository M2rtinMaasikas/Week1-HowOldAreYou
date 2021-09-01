using System;

namespace Fullname
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja käest kasutaja eesnime
            //programm küsib kasutaja käest perekonna nime
            //programm tervitab kasutajat kasutates neid andmeid 
            Console.WriteLine("what is your first name?");
            string FirstName = Console.ReadLine();
            Console.WriteLine("what is your last name?");
            string Lastname = Console.ReadLine();
            Console.WriteLine("Hello," + FirstName +" "+ Lastname);
           
        }
    }
}
