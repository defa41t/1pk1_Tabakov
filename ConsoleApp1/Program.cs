﻿namespace ConsoleApp1
{
    internal class Program
    {
        /*Создайте программу для учета транспортных средств. Используйте перечисление VehicleType:
        • Car
        • Bike
        • Bus
        • Truck
        • Motorcycle
        Храните список транспортных средств (можно просто List<VehicleType>). 
        Добавьте метод для подсчёта транспорта определённого типа (например, сколько грузовиков). 
        Реализуйте поиск по типу и вывод информации.
         */
        static void Main(string[] args)
        {
            
            Console.Write("Введите цифру для поиска количества т/с: ");
            int num = int.Parse(Console.ReadLine());
            VehicleType type = (VehicleType)num;
            Console.WriteLine(type);

            
        }
    }
}
