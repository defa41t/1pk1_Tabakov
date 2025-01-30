namespace Task_05_05
{
    internal class Program
    {
        /* У пользователя в консоли запрашивается числа n и m, генерируется прямоугольный массив целых числе [n*m]. Заполнение 
        случайными числами в диапазоне от -99 до 99 включительно. Осуществите без создания нового массива преобразование текущего 
        по следующему правилу: 
        • Если элемент меньше нуля, то отбрасываем знак и выделяем при выводе зеленым цветом 
        • Если элемент равен нулю, то перезаписываем единицу и выделяем при выводе красным цветом
         */
        static void Main(string[] args)
        {
            // Запрашиваем размеры массива
            Console.Write("Введите количество строк n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов m: ");
            int m = int.Parse(Console.ReadLine());

            
            int[,] array = new int[n, m];
            Random rand = new Random();

            // Заполнение массива
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = rand.Next(-99, 100);
                }
            }

            //Обработка массива
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (array[i, j] < 0)
                    {
                        //Меньше нуля
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(Math.Abs(array[i, j]) + " ");
                    }
                    else if (array[i, j] == 0)
                    {
                        //Равно нулю
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(1 + " ");
                    }
                    else
                    {
                        //Больше нуля
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write(array[i, j] + " ");
                    }
                }
                
                Console.ResetColor();
                Console.WriteLine();
            }

        }
    }
}
