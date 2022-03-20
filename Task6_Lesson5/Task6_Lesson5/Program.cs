// 6) Преобразовать массив так, чтобы на четных позициях стояли элементы с нечетных позиций, и наоборот. Сделать за O(N/2).

class Program
{
    static void Main()
    {
        int[] nums = { 54, 7, -41, 2, 4, 2, 89, 33, -5, 12 };
        int temp;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] > nums[j])
                {
                    temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                }

                Console.WriteLine("Вывод отсортированного массива");
                for (int i = 0; i < nums.Length; i++)
                {
                 Console.WriteLine(nums[i]);
                }
            }
        }
    }
}
