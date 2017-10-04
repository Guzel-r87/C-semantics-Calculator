using System;

/*
Задание: найти значение арифметического выражения, 
не используя переменные
      25 + 689
12 x ---------- - 12 x 3
       60 - 9 
 */
namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(12 * ((25 + 689) / (60 - 9)) - (12 * 3));
            Console.ReadKey();
        }
    }
}