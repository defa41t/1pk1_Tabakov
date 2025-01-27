namespace Task_05_04
{
    internal class Program
    {
        /*Дан квадратный массив размерность n*n. Произведите анализ данной матрицы
        и выясните является ли данная матрица диагональной (все элементы вне главной диагонали равны нулю) 
        Если матрица является диагональной, то вывести ее повторно с цветовым выделением главной диагонали.
        Если нет, то вывести сообщение что матрица не является диагональной. 
         */
        static void Main(string[] args)
        {
            Console.Write("Введите размер матрицы n: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matr = new int[n, n];

            Console.WriteLine("Введите элементы матрицы: ");
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    matr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            //Проверка на диагональность
            bool diagonal = true;  
            for (int i = 0; i < n; i++)
            {
                for(int j = 0;j < n; j++)
                {
                    if (i != j && matr[i, j] != 0)
                    {
                        diagonal = false;
                        break;
                    }
                }if (!diagonal)
                    break;
            }
            if (diagonal)
            {
                Console.WriteLine("Матрица является диагональной.");

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i == j)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(matr[i, j] + " ");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write(matr[i, j] + " ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Матрица не является диагональной");
            }

        }
    }
}
