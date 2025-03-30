namespace Task_21_06
{
    internal class Program
    {
        /*Написать метод, который удаляет повторяющиеся элементы из списка, сохраняя порядок.
         */

        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 5, 12, 62, 23, 54, 12, 75, 43, 63, 45, 92, 54 };
            Console.WriteLine("Список до:");
            foreach (int n in numbers)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Список после: ");
            DeleteDuplicates.RemoveDuplicates(numbers);
            foreach (int i in numbers)
                Console.Write(i + " ");
        }
    }
}
