
// 1) Посчитать количества нечетных и четных элементов массива. Не путать с нечетными и четными индексами.

using System;
class Program
{

    static void Main()
    {
        int [] arr = { 1, 2, 3, 4, 5, 6, 7, -8, -9, -10, 9, 15 };
        var oddNums = arr.Where(i => i % 2 != 0);
        Console.WriteLine("Количество нечетных элементов массива: " + oddNums.LongCount());

        var honestNums = arr.Where(i => i % 2 == 0);
        Console.WriteLine("Количество четных элементов массива: " + honestNums.LongCount());       
    }
}



        
        

    




