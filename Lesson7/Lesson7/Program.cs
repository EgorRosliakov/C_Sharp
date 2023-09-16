using System;
/*створити наступні методи: *
 
/*- Compare, який поверне true, якщо 2 рядки рівні, інакше false, але не використовуйте вбудований метод*/
class Program
{
    static void Main()
    {
        Console.WriteLine(CompareString("Hello", "Helloo"));
        Console.WriteLine(AnalyzeMethod("Hello, world!"));
        Console.WriteLine(SortMethod("Hello"));
        Console.WriteLine(DuplicateMethod("Hello and hi"));
    }


    static bool CompareString(string str1, string str2)
    {
        if (str1.Length != str2.Length)
        {
            return false;
        }
        if (str1 == null || str2 == null)
        {
            return false;
        }
        for (int i = 0; i < str1.Length; i++)
        {
            if (str1[i] != str2[i])
            {
                return false;
            }
        }
        return true;
    }

    /*    Analyze, який поверне кількість літер у рядку, цифр та інших спеціальних символів*/

    static (int numbereLetters, int numbereNumbers, int numberSeparator, int numberPunctuation) AnalyzeMethod(string str3)
    {
        int numbereLetters = 0;
        int numbereNumbers = 0;
        int numberSeparator = 0;
        int numberPunctuation = 0;

        foreach (char item in str3)
        {
            if (char.IsLetter(item))
            {
                numbereLetters++;
            }
            if (char.IsDigit(item))
            {
                numbereNumbers++;
            }
            if (char.IsSeparator(item))
            {
                numberSeparator++;
            }
            if (char.IsPunctuation(item))
            {
                numberPunctuation++;
            }
        }
        return (numbereLetters, numbereNumbers, numberSeparator, numberPunctuation);
    }


    /*-Відсортувати, який поверне рядок, що містить всі символи з вхідного рядка,
      відсортовані в алфавітному порядку (наприклад, 'Hello' -> 'ehllo')*/

    static string SortMethod(string s)
    {
        char[] chars = s.ToLower().ToCharArray();
        for (int i = 0; i< s.Length - 1; i++) 
        {
            for (int j = 0; j < s.Length - i - 1; j++) 
            { 
                if (chars[j] > chars[j+1])
                {
                    (chars[j], chars[j+1]) = (chars[j + 1], chars[j]);
                }
            }
        }
        return new string(chars);
    }

    /*    Duplicate повертає масив символів, які повторюються у вхідному рядку(наприклад, 'Hello and hi' -> ['h', 'l'])
    */

    static string DuplicateMethod(string s)
    {
        string res = "";
        foreach (char c in s)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.ToLower(c) == char.ToLower(s[i]))
                    count++;
            }
            if (count > 1 && res.IndexOf(char.ToLower(c)) == -1)
                res += char.ToLower(c);
        }
        return res;
    }
}


