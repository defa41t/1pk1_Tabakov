using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13_02
{
    /*создать класс питомца
    свойства:
    кличка, вид животного, возраст, вес, отметка о состонии здоровья (здоров/нездоров)
    методы:
    вывод информации об объекте
    изменение значения веса животного
    изменение отметки о состоянии здоровья
    конструторы:
    предусмотрите разные варианты инициализации объектов
     */
    internal class Pet
    {
        public string Name { get; set; } // кличка
        public string Type { get; set; } // вид животного
        public int Age { get; set; } // возраст
        public int Weight { get; set; } // вес
        public bool Health { get; set; }// отметка о состоянии здоровья

        // Конструктор по умолчанию
        public Pet()
        {
            Name = "nameless";
            Type = "unknown";
            Age = 0;
            Weight = 0;
            Health = true;
        }

        // Конструктор с параметрами
        public Pet(string name, string type, int age, int weight, bool health)  
        {
            Name = name;
            Type = type;
            Age = age;
            Weight = weight;
            Health = health;
        }

        // Метод вывода информации
        public void GetInfo()
        {
            Console.WriteLine($"Кличка: {Name}");
            Console.WriteLine($"Вид животного: {Type}");
            Console.WriteLine($"Возраст: {Age}");
            Console.WriteLine($"Вес: {Weight} кг");
            Console.WriteLine($"Состояние здоровья: {(Health ? "здоров" : "нездоров")}");
        }

        // Метод для изменения значения веса животного
        public void ChangeWeight(int newWeight)
        {
            Weight = newWeight;
            Console.WriteLine($"Новый вес: {Weight} кг");
        }

        // Метод для изменения отметки о состоянии здоровья
        public void ChangeHealth(bool healthStatus)
        {
            Health = healthStatus;
            Console.WriteLine($"Текущий статус здоровья обновлен: {(Health ? "здоров" : "нездоров")}");
        }

    }
}
