/*Реалізувати алгоритм сортування:
 - Бульбашка*/

int[] bubls = { 3, -6, 5, 26, 7, 24, 19, -20, 10, 14 };

int temp;

for (int i = 0; i < bubls.Length - 1; i++)
{

    for (int j = i + 1; j < bubls.Length; j++)
    {

        if (bubls[i] > bubls[j])
        {
            temp = bubls[i];
            bubls[i] = bubls[j];
            bubls[j] = temp;
        }
    }
}

Console.WriteLine("Outputting a sorted array");

for (int i = 0;i < bubls.Length; i++)
{
    Console.WriteLine(bubls[i]);
}
