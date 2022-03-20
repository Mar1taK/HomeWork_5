// Поменять местами первую и вторую половину массива

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8};

        int count1 = 0;
        int count2 = array.Length / 2;

        while (count1 < array.Length / 2)
        {
            int temp = array[count1];
            array[count1] = array[count2];
            array[count2] = temp;

            count1++; count2++;
        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
        }
        Console.ReadLine();
    }
}
