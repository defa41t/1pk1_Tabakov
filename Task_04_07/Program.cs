namespace Task_04_07
{
    internal class Program
    {
        /* В массиве на 30 элементов содержатся данные по росту учеников в классе. Рост мальчиков условно задан 
        отрицательными значениями. Вычислить и вывести количество мальчиков и девочек в классе и средний рост для 
        мальчиков и девочек. При выводе избавиться от отрицательных значений.
         */
        static void Main(string[] args)
        {
            Random rand = new Random();
            double[] heights = new double[30];

            // Заполнение массива значениями роста
            for (int i = 0; i < heights.Length; i++)
            {
                // Условно задаем рост мальчиков как отрицательные значения
                if (i % 2 == 0) 
                {
                    heights[i] = -rand.Next(150, 200); // Отрицательные значения
                }
                else //девочки
                {
                    heights[i] = rand.Next(150, 200); 
                }
            }

            int boysCount = 0;
            int girlsCount = 0;
            double boysSum = 0;
            double girlsSum = 0;

            // Подсчет количества и суммы роста для мальчиков и девочек
            foreach (var height in heights)
            {
                if (height < 0) // Мальчики
                {
                    boysCount++;
                    boysSum += -height; 
                }
                else // Девочки
                {
                    girlsCount++;
                    girlsSum += height;
                }
            }

            // Вычисление среднего роста
            double boysAverage = boysCount > 0 ? boysSum / boysCount : 0;
            double girlsAverage = girlsCount > 0 ? girlsSum / girlsCount : 0;

            // Вывод результатов
            Console.WriteLine($"Количество мальчиков: {boysCount}");
            Console.WriteLine($"Средний рост мальчиков: {Math.Round(boysAverage)} см");
            Console.WriteLine($"Количество девочек: {girlsCount}");
            Console.WriteLine($"Средний рост девочек: {Math.Round(girlsAverage)} см");
        }
    }
}
