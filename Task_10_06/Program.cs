namespace Task_10_06
{
    internal class Program
    {
        /*Создать Метод ArrayGeneration не возвращающий значения, 
         * принимает целое число n, 
         * выводит наконсольсгенерированный массив размерности n*n.
         */
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива n: ");
            int n = int.Parse(Console.ReadLine());
            // Вызов метода
            ArrayGeneration(n);
        }

        
        static void ArrayGeneration(int n)
        {
            // Создаем двумерный массив
            int[,] array = new int[n, n];

            // Заполняем массив случайными числами
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = rand.Next(0, 101); 
                }
            }

            // Вывод массива
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j] + " "); 
                }
                Console.WriteLine(); 
            }
        }
    }
}
