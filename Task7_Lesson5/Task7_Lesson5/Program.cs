// В массиве из целочисленных элементов (включая отрицательные) вычислить:
// а) минимальный по модулю элемент массива;
// б) сумму элементов, расположенных после первого нулевого элемента (элемента, равного нулю).
// Сделать одним проходом цикла!

class Program
{
    static void Main()
    {
        Console.Write("Введите количество элементов массива: ");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        Random r = new Random();
        for (int i = 0; i < n; i++)
        {
            a[i] = r.Next(-25, 25);
            Console.Write(a[i].ToString() + "  ");
        }
        Console.WriteLine();
        int min = Math.Abs(a[0]);
        for (int i = 0; i < n; i++)
            if (Math.Abs(a[i]) <= Math.Abs(min))
                min = a[i];
        Console.WriteLine("Минимальный по модулю элемент массива: " + min.ToString());
        int zero_index = 0;
        bool check = false;
        for (int i = 0; i < n; i++)
            if (a[i] == 0)
            {
                zero_index = i;
                check = true;
                break;
            }
        if (check)
        {
            int sum = 0;
            for (int i = zero_index + 1; i < n; i++)
                sum += a[i];
            Console.WriteLine("Сумма элементов, расположенных после первого нулевого элемента (элемента, равного нулю) : " + sum.ToString());
        }
        else
            Console.WriteLine("В массиве нет нулевых элементов.");

       Console.ReadKey();
    }
}






