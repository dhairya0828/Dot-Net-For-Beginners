using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

// Simple Practical to take name and country as a input from user and display it after validating it
namespace Practical3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, country;
            Regex regex = new Regex(@"^[a-z]+$", RegexOptions.IgnoreCase);
            // In this ary ^ stands for "must start with", + stands for 1 or more chars, $ stands for must end with

            Console.WriteLine("!!! Warning :- Entered Name and Countery must be alphabets only else you will have to enter again.");

            
            do {
                Console.Write("Enter Your Name : ");
                name = Console.ReadLine();
            } while (regex.IsMatch(name) == false);
            
            do
            {
                Console.Write("Enter Your Country name : ");
                country = Console.ReadLine();
            } while (regex.IsMatch(country) == false);

            Console.WriteLine("Hey " + name + ", We know you love " + country + ".");
            Console.Read();
        }
    }
}
