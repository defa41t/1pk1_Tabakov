namespace Task_03_07
{
    internal class Program
    {
        /* Написать программу, которая выводит таблицу скорости (через каждые 0,5с) свободно падающего тела v = g t , 
        где 2 g = 9,8 м/с2 –ускорение свободного падения.

         */
        static void Main(string[] args)
        {
            //Ввод данных
            double g = 9.8;
            double t = 0; 
            //Цикл
            while (t <= 10)
            {
                double v = g * t;
                Console.WriteLine("t = " + t + "c, v = " + Math.Round(v, 1) + "м/c");
                t += 0.5;
            }
        }
    }
}
