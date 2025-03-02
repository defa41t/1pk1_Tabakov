using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13_03
{
    /*создайте класс автомобиля
    свойства:
    номер авто, марка, цвет, текущая скорость
    методы:
    езда (симитировать равномерное ускорение скорости автомобиля)
    торможение (при превышении скорости автомобиля свыше допустимой - он должен остановиться)
    конструторы
    предусмотрите разные варианты инициализации объектов
     */
    internal class Car
    {
        public string Number { get; set; } //номер авто
        public string Brand { get; set; } //марка
        public string Color { get; set; } //цвет
        public int Speed { get; set; } // текущая скорость

        public int MaxSpeed { get; set; } = 50; // максимальная скорость

        // Конструктор по умолчанию
        public Car(string number, string brand, string color, int speed)
        {
            Number = number;
            Brand = brand;
            Color = color;
            Speed = speed;
        }

        // Метод класса - движение
        public void Drive(int delta)
        {
            for (int i = 0; i < 20; i++)
            {

                if (Speed <= MaxSpeed)
                {
                    Speed += delta;
                    Console.Write($"Текущая скорость автомобиля {Brand}, цвет: {Color}, с номерами: {Number}  - {Speed}\n");
                }
            }

        }

        // Метод класса - торможение
        public void Stop(int delta)
        {
            for (int i = 0;i < 20;i++)
            {
                if (Speed > MaxSpeed)
                    Console.WriteLine($"Автомобиль с номерами {Number} ПРЕВЫСИЛ СКОРОСТЬ!!!.");

                if (Speed > 0)
                {
                    Speed -= delta;
                    Console.WriteLine($"Скорость - {Speed}");
                }
            }
        }
    }
}
