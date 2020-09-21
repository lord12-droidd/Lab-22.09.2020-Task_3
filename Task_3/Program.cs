using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Task_3
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag == true)
            {
                try
                {
                    Console.OutputEncoding = System.Text.Encoding.Unicode;
                    flag = false;
                    Console.WriteLine("Введіть змінну типу int ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введіть змінну типу double");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введіть змінну типу long");
                    long c = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine($"a = {a}; b = {b}; c = {c}");
                    Console.ReadKey();
                }
                catch
                {
                    flag = true;
                    Console.WriteLine("Enter correct value");
                }
            }

        }
    }
}
