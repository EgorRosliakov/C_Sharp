/* Homework написати програму яка запитуватиме у користувача початкове і кінцеве значення змінної x, 
 * та виводиме на екран суму парних числел від початкового до кінцевого значення х 
 * і суму непарних чисел від початкового до кінцевого значення х. */

using System;
namespace Lesson2
{
    class Program
    {
        static void Main()
        {
            Console.Write("enter the starting number: ");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter the end number: ");
            int end = Convert.ToInt32(Console.ReadLine());

            if (start > end || start < 0 || end < 0)
            {
                Console.WriteLine("error, please try again");
                return;
            }

            int evenAmount = 0, oddAmount = 0;

            for (int i = start; i <= end; i++)
            {

                if (i % 2 == 0)
                    evenAmount = evenAmount + i;
                else
                    oddAmount += i;
            }

            Console.WriteLine($"The sum of your even numbers = {evenAmount}");
            Console.WriteLine($"The sum of your odd numbers = {oddAmount}");
        }
    }
}
