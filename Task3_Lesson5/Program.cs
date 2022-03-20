//  3. Слить два целочисленных массива в один (должен получиться третий массив).

using System;

class Program
{
    static void Main()
    {
        {
            int[] array1 = { 1, 10, 18, 25, 78,100, -25 };
            int[] array2 = { -4, 5, 6, -15 };
            int[][] toMerge = { array1, array2 };

            int[] result = new int[array1.Length + array2.Length];

            for (int i = 0, j = 0; i < toMerge.Length; i++)
            {                
                for (int k = 0; k < toMerge[i].Length; k++)
                {
                    result[j] = toMerge[i][k];
                    j++;
                    Console.WriteLine(toMerge[i][k]);
                }
            }
            


        }

    }
}






    

