using System;

class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        double result1 = 0;
        double result2 = 0;
        double result3 = 0;
        double result4 = 0;

        // Спосіб 1: while(...)
        int i = 1;
        while (i <= n)
        {
            result1 += (1 + i / n) / Math.Pow(i, 2);
            i++;
        }

        // Спосіб 2: do { ... } while(...)
        i = 1;
        do
        {
            result2 += (1 + i / n) / Math.Pow(i, 2);
            i++;
        } while (i <= n);

        // Спосіб 3: for(...; ...; n++)
        for (i = 1; i <= n; i++)
        {
            result3 += (1 + i / n) / Math.Pow(i, 2);
        }

        // Спосіб 4: for(...; ...; n--)
        for (i = n; i >= 1; i--)
        {
            result4 += (1 + i / n) / Math.Pow(i, 2);
        }

        Console.WriteLine("Результат за способом 1: " + result1);
        Console.WriteLine("Результат за способом 2: " + result2);
        Console.WriteLine("Результат за способом 3: " + result3);
        Console.WriteLine("Результат за способом 4: " + result4);

        if (result1 == result2 && result2 == result3 && result3 == result4)
        {
            Console.WriteLine("Результати збiгаються.");
        }
        else
        {
            Console.WriteLine("Результати не збiгаються.");
        }
    }
}
