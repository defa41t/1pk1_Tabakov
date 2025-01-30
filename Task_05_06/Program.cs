namespace Task_05_06
{
    internal class Program
    {
        /* Осуществить генерация двумерного [10*5] массива по следующему правилу: 
        • 1 столбец содержит нули 
        • 2 столбце содержит числа кратные 2 
        • 3 столбец содержит числа кратные 3 
        • 4 столбец содержит числа кратные 4 
        • 5 столбец содержит числа кратные 5 
        Осуществить переворот массива (поменять строки и столбцы местами) вывести обновленный массив
         */
        static void Main(string[] args)
        {
            
            int[,] array = new int[10, 5];

            for(int i = 0; i < 10; i++)
            {
                array[i, 0] = 0;
                array[i, 1] = (i + 1) * 2;
                array[i, 2] = (i + 2) * 3;
                array[i, 3] = (i + 3) * 4;
                array[i, 4] = (i + 4) * 5;
                
            }
            //Вывод основного массива
            Console.WriteLine("Основной массив: ");
            for(int i = 0;i < array.GetLength(0);i++)
            {
                for(int j = 0;j < array.GetLength(1);j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            //Изменение массива
            int[,] array2 = new int[5, 10];

            for(int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array2[j, i] = array[i, j];
                }
            }

            //Вывод измененного массива
            Console.WriteLine("Измененный массив: ");
            for (int i = 0; i < 5; i++)
            {
                for ( int j = 0; j < 10;  j++)
                {
                    Console.Write(array2[i, j]  + "\t");
                }
                Console.WriteLine();
            }

        }
        
        
    }
}
