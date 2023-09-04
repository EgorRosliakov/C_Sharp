//byte, short, int, long, bool, char, float, double, decimal, string
//-6*x^3+5*x^2-10*x+15
//abs(x) * sin(x)
//2 * pi * x
//max(x, y)

using System;

namespace Lesson1
{
    class Program
    {

/*        static void Main(string[] args)
        {
            Console.WriteLine("Простой калькулятор");

            Console.WriteLine("\nВведите первое целое число");
            int num_1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("\nВведите второе число");
            int num_2 = Convert.ToInt16(Console.ReadLine());

            int res_sum = Convert.ToInt32(num_1 + num_2);
            int res_sub = Convert.ToInt16(num_1 - num_2);
            int res_div = (int)(num_1 / num_2);
            int res_mul = (int)(num_1 * num_2);

            Console.WriteLine($"\nСложение {num_1} + {num_2} = {res_sum}");
            Console.WriteLine($"\nВычитание {num_1} - {num_2} = {res_sub}");
            Console.WriteLine($"\nДеление {num_1} / {num_2} = {res_div}");
            Console.WriteLine($"\nУмножение {num_1} * {num_2} = {res_mul}");
        }*/


        /*static void Main(string[] args)
        {
            Console.Write("Введите имя ");
            string name = Console.ReadLine();
            Console.WriteLine("Привет " + name);
        }*/


        /*        static void Main(string[] args)
                {
                    Console.Write("Решаем уравнение a+b, где а=10, b=20");
                    byte a = 10, b = 20;
                    byte res = Convert.ToByte((a + b));
                    Console.WriteLine("\nСумма " + res);
                }*/


        /*        static void Main(string[] args)
                {
                    Console.Write("Решаем уравнение -6*x ");
                    Console.WriteLine("\nВведите целое число");
                    short x = (short)Convert.ToDouble(Console.ReadLine());
                    short res = (short)(-6 * x);
                    Console.WriteLine("\nРезультат " + res);
                }*/


        /*        static void Main(string[] args)
                {
                    Console.Write("Решаем уравнение 3+5*x ");
                    Console.WriteLine("\nВведите значение х");
                    int x = int.Parse(Console.ReadLine());
                    int res = 3 + 5 * x;
                    Console.WriteLine("\nРезультат " + res);
                }*/


        /*static void Main(string[] args)
        {
            Console.Write("Решаем уравнение 2-10*x+15");
            Console.WriteLine("\nВведите значение х");
            long x = long.Parse(Console.ReadLine());
            long res = 2 - 10 * x + 15;
            Console.WriteLine("\nРезультат" + res);
        }*/


        /*        static void Main(string[] args)
                {
                    Console.Write("Решаем задачу abs(x) * sin(x) ");
                    Console.WriteLine("\nВведите значение х");
                    double x = int.Parse(Console.ReadLine());
                    double res = Convert.ToDouble(Math.Abs(x) * Math.Sin(x));
                    Console.WriteLine("\nРезультат " + res);
                }*/


        /*        static void Main(string[] args)
                {
                    Console.Write("Решаем уравнение 2 * pi * x");
                    Console.WriteLine("\nВведите значение х");
                    float x = float.Parse(Console.ReadLine());
                    float res = (float)(2 * Math.PI * x);
                    Console.WriteLine("\nРезультат " + res);
                }*/


        /*        static void Main(string[] args)
                {
                    Console.Write("Решаем уравнение, найдём большее число из 2х max(x, y) ");
                    Console.WriteLine("\nВведите первое число");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nВведите второе число");
                    int y = int.Parse(Console.ReadLine());
                    int res = Math.Max(x, y);
                    Console.WriteLine("\nБольшее число " + res);
                }*/

    }
}
