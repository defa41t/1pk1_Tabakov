namespace Task_10_08
{
    internal class Program
    {
        /*Создайте метод, который на вход принимает одномерный массив 
         * и число для поиска, верните индекc искомого элемента в массиве. 
         * Если элемента нет – верните индекс = -1
         */
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rnd = new Random();
            //Заполнение массива
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 11);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            //Запрос числа для поиска
            Console.Write("Введите число для поиска: ");
            int num = int.Parse(Console.ReadLine());

            int index = FindIndex(array, num);
            //Вывод индекса элемента
            Console.WriteLine("Индекс элемента: " + index);
        }

        static int FindIndex(int[] array, int num)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == num)
                {
                    return i; // Возвращаем индекс найденного элемента
                }
            }
            return -1; // Возвращаем -1, если элемент не найден
        }
    }
}
