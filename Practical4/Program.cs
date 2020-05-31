using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical4
{
    class Program
    {
        bool IsAlNum(char c)
        {
         //   Console.WriteLine(c);
            if (c >= 'a' && c <= 'z')
                return true;
            if (c >= 'A' && c <= 'Z')
                   return true;
            return false;
        }
        int Priority(char c)
        {
            if (c == '^' || c == '$')
                return 3;
            if (c == '%' || c == '*' || c == '/')
                return 2;
            if (c == '+' || c == '-')
                return 1;
            
            return 0;
        }
        string InfixToPostfix(string infix)
        {
            Stack<char> s = new Stack<char>();
            string postfix = "";
            for (int i = 0; i < infix.Length; i++)
            {
                char ch = infix[i];

                if(!IsAlNum(ch))
                {
                    if (s.Count == 0)
                    {
                        s.Push(ch);
                        continue;
                    }
                    
                    while(s.Count !=0 && Priority(s.Peek()) >= Priority(ch))
                        postfix += s.Pop();
                    s.Push(ch);
                }
                else
                    postfix += ch;
            }
            while (s.Count != 0)
                postfix += s.Pop();
            return postfix;
        }
        static void Main(string[] args)
        {
            string infix;
            Console.Write("Enter Infix String : ");
            infix = Console.ReadLine();
            Program p = new Program(); 
            string postfix = p.InfixToPostfix(infix);
            Console.Write("Postifix is : " + postfix);
            Console.Read();
        }
    }
}
