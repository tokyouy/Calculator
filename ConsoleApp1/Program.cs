using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double first_num;
            double second_num;
            double total;
            char alert;
            try
            {
                // Первое число
                Console.WriteLine("Введите первое число");
                first_num = Convert.ToDouble(Console.ReadLine());
                // Знак
                Console.WriteLine("Введите знак");
                alert = Convert.ToChar(Console.ReadLine());
                // Второе число
                Console.WriteLine("Введите второе число");
                second_num = Convert.ToDouble(Console.ReadLine());
                if (alert == '+')
                {
                    total = first_num + second_num;
                    Console.WriteLine(total);
                }
                else if (alert == '*')
                {
                    total = first_num * second_num;
                    Console.WriteLine(total);
                }
                else if (alert == '/')
                {
                    total = first_num / second_num;
                    if (second_num == 0)
                    {
                        Console.WriteLine("На ноль делить нельзя");
                    }
                    else
                    {
                        Console.WriteLine(total);
                    }
                }
                else if (alert == '-')
                {
                    total = first_num - second_num;
                    Console.WriteLine(total);
                }
                else
                {
                    Console.WriteLine("Неизвестный знак");
                }
                Console.ReadLine();
            }
            catch (System.Exception)
            {
                Console.WriteLine("Что-то было введено не правильно!");
            }
            
        }
    }
}
