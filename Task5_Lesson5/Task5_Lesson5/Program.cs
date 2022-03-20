// 5) Циклически двинуть массив вправо на 1 элемент. Например: 1 2 3 4 5 -> 5 1 2 3 4. А после этого сделать циклический сдвиг вправо на N элементов.
//    (очевидная подсказка: завернуть циклический сдвиг вправо на 1 элемент в еще один цикл на N итераций).

class Program
{
    static void Main()
    {
        const int n = 5;
        int[] a = new int[n] { 1, 2, 3, 4, 5 };
        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < n; ++i)
        Console.Write("\t" + a[i]);
        Console.WriteLine();
        
        int k = 1;
     
        for (int i = 0; i < k; ++i)
        {
            int aLast = a[n - 1];
            for (int j = n - 1; j > 0; --j) a[j] = a[j - 1];
            a[0] = aLast;
        }

        Console.WriteLine("Массив после сдвига: ");
        for (int i = 0; i < n; ++i)
        Console.Write("\t" + a[i]);
        Console.WriteLine();

        Console.ReadKey();
    }
}