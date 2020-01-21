using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical2 // This practical prints different patterns 
{
    class Program
    {
        /* * This pattern prints
         *   * * * * *
         *   * * * * *
         *   * * * * *
         *   * * * * *
         *   * * * * *
        */  
        public static void Pattern1()
        {
            for(int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                    Console.Write(" *");
                Console.WriteLine();
            }
        }
        /* * This pattern prints
         *   * 
         *   * * 
         *   * * *
         *   * * * *
         *   * * * * *
        */  
        
        public static void Pattern2()
        {
            for(int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                    Console.Write(" *");
                Console.WriteLine();
            }
        }

        /* * This pattern prints
         *   * * * * *
         *   * * * *
         *   * * * 
         *   * * 
         *   * 
        */

        public static void Pattern3()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int k = 4; k > i; k--)
                    Console.Write(" ");
                for (int j = 0; j <= i; j++)
                    Console.Write(" *");
                Console.WriteLine();
            }
        }

        /* * This pattern prints
        *       * 
        *      * * 
        *     * * *
        *    * * * *
        *   * * * * *
       */

        public static void Pattern4()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int k = 4; k > i; k--)
                    Console.Write(" ");
                for (int j = 0; j <= i; j++)
                    Console.Write(" *");
                Console.WriteLine();
            }
        }

        /* * This pattern prints
        *   * * * * *
        *    * * * *
        *     * * *
        *      * *
        *       *
       */

        public static void Pattern5()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int k = 0; k < i; k++)
                    Console.Write(" ");
                for (int j = 4-i; j >= 0; j--)
                    Console.Write(" *");
                Console.WriteLine();
            }
        }

        
        /* * This pattern prints
        *       * 
        *      * * 
        *     * * *
        *    * * * *
        *   * * * * *
        *    * * * *
        *     * * *
        *      * *
        *       *
       */

        public static void Pattern6()
        {
            for(int i = 0; i < 9; i++)
            {
                if (i < 5)
                {
                    for (int k = 4; k > i; k--)
                        Console.Write(" ");
                    for (int j = 0; j <= i; j++)
                        Console.Write(" *");
                    Console.WriteLine();
                }
                else
                {
                    for (int k = 0; k < i-4; k++)
                        Console.Write(" ");
                    for (int j = 8 - i; j >= 0; j--)
                        Console.Write(" *");
                    Console.WriteLine();
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\tPattern 1\n");
            Pattern1();

            Console.WriteLine("\tPattern 2\n");
            Pattern2();

            Console.WriteLine("\tPattern 3\n");
            Pattern3();

            Console.WriteLine("\tPattern 4\n");
            Pattern4();

            Console.WriteLine("\tPattern 5\n");
            Pattern5();

            Console.WriteLine("\tPattern 6\n");
            Pattern6();

            Console.Read();
        }
    }
}
