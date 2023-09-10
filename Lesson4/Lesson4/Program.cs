/*Опишіть і викличте з різними параметрами наступні методи:*/

/*Метод min*/
     static int MethodMin(int x, int y)
    {
        return Math.Min(x, y);
    }
    Console.WriteLine(MethodMin(10, 20));
    Console.WriteLine(MethodMin(100, 20));

/*Метод max*/
    static int MethodMax(int x, int y)
{
    return Math.Max(x, y);
}
Console.WriteLine(($"Max number {MethodMax(10, 20)}"));

/*Метод minMax*/
static void MethodMaxMin(int max, int min)
{
    // Для корректного обміну значеннями, використовуємо тимчасову змінну
    int temp = max;
    max = Math.Max(max, min);
    min = Math.Min(temp, min);
    Console.WriteLine($"Max number: {max} \nMin number {min}");
}
MethodMaxMin(10, 20);
MethodMaxMin(50, 30);

/*-Перевантажити перші два методи 3 та 4 параметрами*/
static int MethodMin3(int x, int y, int z)
{
    return Math.Min(Math.Min(x, y), z);
}
Console.WriteLine(MethodMin3(10, 20, 30));
Console.WriteLine(MethodMin3(100, 20, 50));

static int MethodMax4(int x, int y, int z, int b)
{
    return Math.Max(Math.Max(Math.Max(x, y), z), b);
}
Console.WriteLine(($"Max number {MethodMax4(10, 20, 30, 40)}"));


/*- Метод TrySumIfOdd, який приймає 2 параметри і повертає true, 
   якщо сума чисел між входами непарна, інакше false, сума повертається як вихідний параметр*/

static bool TrySumIfOdd(int x, int y, out int s)
{
    s = 0;

    for (int i = x + 1; i < y; i++)
    {
        s += i;
    }
    return s % 2 != 0;
}


/*Перевіряємо*/

int result;
bool oddSum = TrySumIfOdd(2, 10, out result);

if (oddSum)
{
    Console.WriteLine($"The amount is odd: {result}");

}
else
{
    Console.WriteLine($"The amount is even: {result}");
}


