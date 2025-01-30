namespace Task_05_07
{
    internal class Program
    {
        /* У пользователя в консоли запрашивается число n, генерируется квадратный массив целых числе [n*n]. 
         * Заполнение случайными числами в диапазоне от 10 до 99 включительно. 
        Найти и вывести отдельно минимальный элемент в матрице (LINQ под запретом) 
        Осуществить умножение матрицы на ее минимальный элемент, 
        при выводе цветом выделить пять максимальных значений в массиве 
         */
        static void Main(string[] args)
        {
            Console.Write("Введите размер матрицы n: ");
            int n = int.Parse(Console.ReadLine());

            Random rnd = new Random();
            int[,] array = new int[n, n];
            //Заполнение матрицы
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(10, 100);
                }
            }

            //Поиск минимального значения
            int min = array[0,0];
            for (int i = 0;i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (array[i,j] < min)
                        min = array[i,j];
                }
            }
            Console.WriteLine("Минимальный элемент: " + min);

            //Умножение на минимальное значение
            for (int i = 0; i < n; i++)
            {
                for (int j = 0;j < n; j++)
                {
                    array[i, j] *= min;
                }
            }

            //Нахождение 5 максимальных значений
            int[] max = new int[5];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int temp = array[i, j];
                    for (int g = 0; g < 5; g++)
                    {
                        if (temp > max[g])
                        {
                            
                            for (int f = 4; f > g; f--)
                            {
                                max[f] = max[f - 1];
                            }
                            max[g] = temp;
                            break;
                        }
                    }
                }
            }
            //Вывод матрицы
            Console.WriteLine("Матрица после умножения:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    // Проверка на максимальные значения для окрашивания
                    bool isMax = Array.Exists(max, element => element == array[i, j]);
                    if (isMax)
                    {
                        Console.ForegroundColor = ConsoleColor.Green; 
                        Console.Write(array[i, j] + "\t");
                        Console.ResetColor(); 
                    }
                    else
                    {
                        Console.Write(array[i, j] + "\t");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
