namespace Task_04_05
{
    internal class Program
    {
        /* В массиве хранятся сведения о количестве осадков за месяц (30 дней). Необходимо определить общее 
        количество осадков, выпавших за каждую декаду месяца, вывести день с самыми сильными осадками за месяц и 
        отдельно вывести дни без осадков. Массив с осадками заполнятся с помощью рандома в диапазоне от 0 – нет 
        осадков, до 300 мм выпавших осадков.

         */
        static void Main(string[] args)
        {
            int[] rain = new int[30];
            Random rnd = new Random();

            //заполнение массива

            for (int i = 0; i < rain.Length; i++)
            {
                rain[i] = rnd.Next(0, 301);
            }

            //осадки декад
            int[] decades = new int[3];
            for (int i = 0; i < rain.Length; i++)
            {
                if (i < 10)
                    decades[0] += rain[i]; // 1-я декада
                else if (i < 20)
                    decades[1] += rain[i]; // 2-я декада
                else
                    decades[2] += rain[i]; // 3-я декада
            }
            //нахождение дня с самым большим количеством осадков
            int maxRain = 0;
            int days = -1;
            for (int i = 0; i < rain.Length; i++)
            {
                maxRain = rain[i];
                days = i + 1;
            }
            //Вывод
            Console.WriteLine($"1-ая декада: {decades[0]}");
            Console.WriteLine($"2-ая декада: {decades[1]}");
            Console.WriteLine($"3-ая декада: {decades[2]}");
            Console.WriteLine($"День с самыми сильными осадками: {days} (осадки: {maxRain} мм)");

            Console.WriteLine("Дни без осадков:");
            for (int i = 0; i < rain.Length; i++)
            {
                if (rain[i] == 0)
                {
                    Console.WriteLine($"День {i + 1}");
                }
            }
        }
    }
}
