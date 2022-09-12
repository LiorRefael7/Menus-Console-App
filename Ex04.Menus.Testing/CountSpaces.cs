using Ex04.Menus.Interfaces;
using System;

namespace Ex04.Menus.Testing
{
    public class CountSpaces : IInvoker
    {
        public void Invoke()
        {
            FunctionCountSpaces();
        }

        public static void FunctionCountSpaces()
        {
            Console.WriteLine("Please Enter a string");
            string input = Console.ReadLine();
            int count = 0;

            foreach (char c in input)
            {
                if (c.Equals(' '))
                {
                    count++;
                }
            }

            Console.WriteLine(String.Format("there is {0} spaces in the string", count));
        }
    }
}
