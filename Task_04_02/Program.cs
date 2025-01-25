namespace Task_04_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива: ");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int CountOfNegative = 0;

            int i = 0;
            Random random = new Random();
            while (i < numbers.Length)
            {
                //TODO
                int temp = random.Next(-10, 11);
                if (temp == 0)
                    continue;
                numbers[i] = temp;
                if (numbers[i] < 0) CountOfNegative++;
                Console.Write(numbers[i] + " ");
                i++;
                
            }
            int[] negative = new int(CountOfNegative);

        }
    }
}
