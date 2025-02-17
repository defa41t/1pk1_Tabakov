﻿namespace Task_11_01
{
    internal class Program
    {
        /*Передача по значению: Напишите метод, который принимает два целых числа и меняет их
        местами. Проверьте, изменились ли значения переменных вне метода
         */
        static void Main(string[] args)
        {
            int num1 = 2;
            int num2 = 7;
            Console.WriteLine($"Числа: {num1}, {num2}");
            Reverse(ref num1, ref num2);
            Console.WriteLine($"Числа после замены местами: {num1}, {num2}");
        }

        static void Reverse(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
