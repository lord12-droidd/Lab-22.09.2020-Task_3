using System;
using System.Diagnostics.Tracing;
using System.Threading;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            int a = 0;
            double b = 0;
            long c = 0;

            bool flag = false;
            while (flag == false)
            {
                flag = true;
                try
                {
                    Console.Write("Введіть змінну типу int: ");
                    a = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Неправильний тип змінної");
                    flag = false;
                }
            }

            while (flag == true)
            {
                try
                {
                    flag = false;
                    Console.Write("Введіть змінну типу double: ");
                    b = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Неправильний тип змінної");
                    flag = true;
                }
            }

            while (flag == false)
            {
                try
                {
                    flag = true;
                    Console.Write("Введіть змінну типу long: ");
                    c = Convert.ToInt64(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Неправильний тип змінної");
                    flag = false;
                }
            }
            Console.WriteLine($"a = {a}; b = {b}; c = {c}");
            Console.ReadKey();
        }
    }
}

