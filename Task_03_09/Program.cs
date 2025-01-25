namespace Task_03_09
{
    internal class Program
    {
        /* Вклад в банке составляет x рублей. Ежегодно он увеличивается на p процентов, после чего дробная часть копеек 
        отбрасывается. Каждый год сумма вклада становится больше. Определите, через сколько лет вклад составит не 
        менее y рублей.
         */
        static void Main(string[] args)
        {
            //Получение данных
            Console.Write("Сумма вклада: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Проценты в год: ");
            double p = double.Parse(Console.ReadLine());

            Console.Write("Желаемая сумма вклада: ");
            double y = double.Parse(Console.ReadLine());

            int years = 0;

            //Рассчеты и вывод
            while (x < y)
            {
                x += x * p / 100;
                x = Math.Floor(x * 100) / 100;
                years++;
                
            }
            Console.WriteLine(years);

        }
    }
}
