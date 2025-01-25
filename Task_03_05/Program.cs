namespace Task_03_05
{
    internal class Program
    {
        /* Написать программу, которая выводит на экран таблицу соответствия температуры в градусах Цельсия и 
        Фаренгейта (F = C*1,8 + 32). Диапазон изменения температуры в градусах Цельсия и шаг должны вводиться во 
        время работы программы

         */
        static void Main(string[] args)
        {
            //Ввод данных
            Console.WriteLine("Введите начальную температуру в градусах Цельсия:");
            double start = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите конечную температуру в градусах Цельсия:");
            double end = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите шаг изменения температуры:");
            double step = double.Parse(Console.ReadLine());

            Console.WriteLine("Температура в градусах Цельсия\tТемпература в градусах Фаренгейта");

            //Расчеты
            for (double celsius = start; celsius <= end; celsius += step)
            {
                double fahrenheit = celsius * 1.8 + 32;
                Console.WriteLine($"{celsius}\t\t\t\t{fahrenheit}");
            }
        }

    }
}
