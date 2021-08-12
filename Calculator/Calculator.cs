using System;

namespace calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            string opr = Console.ReadLine();
            int b = Convert.ToInt32(Console.ReadLine());

            if (opr == "+")
                Console.WriteLine(a + b);
            if (opr == "-")
                Console.WriteLine(a - b);
            if (opr == "*")
                Console.WriteLine(a * b);
            if (opr == "/")
                Console.WriteLine(a / b);
            else
                Console.WriteLine("error");
        }
    }
}
