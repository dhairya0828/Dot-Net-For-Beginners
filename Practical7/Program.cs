using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical7
{
    class Program
    {
        static string numberToWords(int number)
        {
            string words = "";
            switch (number)
            {
                case 0: words = "zero"; break;
                case 1: words = "one"; break;
                case 2: words = "two"; break;
                case 3: words = "three"; break;
                case 4: words = "four"; break;
                case 5: words = "five"; break;
                case 6: words = "six"; break;
                case 7: words = "seven"; break;
                case 8: words = "eight"; break;
                case 9: words = "nine"; break;
                case 10: words = "ten"; break;
                case 11: words = "eleven"; break;
                case 12: words = "twelve"; break;
                case 13: words = "thirteen"; break;
                case 14: words = "fourteen"; break;
                case 15: words = "fifteen"; break;
                case 16: words = "sixteen"; break;
                case 17: words = "seventeen"; break;
                case 18: words = "eighteen"; break;
                case 19: words = "nineteen"; break;
                case 20: words = "twenty"; break;
                case 30: words = "thirty"; break;
                case 40: words = "forty"; break;
                case 50: words = "fifty"; break;
                case 60: words = "sixty"; break;
                case 70: words = "seventy"; break;
                case 80: words = "eighty"; break;
                case 90: words = "ninety"; break;
                case 100: words = "hundred"; break; //number > 100
                case 1000: words = "thousand"; break; //number > 1000
                case 1000000: words = "million"; break; //number > 1000

            }
            return words;
        }

        static int numberOfDigits(int number)
        {
            return (int)(Math.Log10(number) + 1);
        }

        static void Main(string[] args)
        {
            int number = 5678, i = numberOfDigits(number);
            Console.Write(number + "    in words :: ");
            while (number > 0)
            {
                int tempNumber;
                if (number % Math.Pow(10, i) > Math.Pow(10, i - 1))
                {
                    tempNumber = number % (int)Math.Pow(10, i);
                    if (tempNumber > 100)
                    {
                        Console.Write(numberToWords(tempNumber / (int)Math.Pow(10, i - 1)) + " ");
                        Console.Write(numberToWords((int)Math.Pow(10, i - 1)) + " ");
                    }
                    else
                    {
                        if (tempNumber > 19)
                            Console.Write(numberToWords(tempNumber / 10 * 10) + " ");
                        else
                        {
                            Console.Write(numberToWords(tempNumber) + " ");
                        }
                    }
                }
                number = number % (int)Math.Pow(10, i - 1);
                i--;
            }
            Console.ReadLine();
        }
    }
}
