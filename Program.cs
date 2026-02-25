using System;

namespace MyConsoleApp
{
    public class Logic
    {
        public static int Calculate(int a, int b, int c)
        {
            int res = 0;
            if (a > b && a > c)
            {
                res = b * c;
                return res;
            }
            else if (b > a && b > c)
            {
                res = a * c;
                return res;
            }
            else
            {
                res = a * b;
                return res;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите три числа по очереди \n");

            string a_str = Console.ReadLine();
            string b_str = Console.ReadLine();
            string c_str = Console.ReadLine();

            int a = Convert.ToInt32(a_str);
            int b = Convert.ToInt32(b_str);
            int c = Convert.ToInt32(c_str);

            int res = Logic.Calculate(a, b, c);

            Console.WriteLine($"Числа: {a} {b} {c}");
            Console.WriteLine($"результат: {res}");
        }
    }
}