namespace Task_04_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[30];
            Random rnd = new Random();
            //заполнение массива и вывод
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rnd.Next(10, 100);
                Console.WriteLine(nums[i] + " ");
            }
            //поиск пар, начиная со второго элемента
            int count = 0;
            for (int ind = 0; ind < nums.Length; ind++)
            {
                if (nums[ind] % 5 == 0 && nums[ind - 1] % 5 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"Количество пар чисел кратных пяти: {count}");
        }
    }
}
