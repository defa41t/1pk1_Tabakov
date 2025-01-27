using System;

namespace Task_04_06
{
    internal class Program
    {
        /*Заполнить массив случайными положительными и отрицательными числами таким образом, чтобы все числа по 
        модулю были разными. Это значит, что в массиве не может быть ни только двух равных чисел, но не может быть 
        двух равных по модулю. В полученном массиве найти наибольшее по модулю число.

         */
        static void Main(string[] args)
        {

            
            int[] array = new int[10];
            int[] array1 = new int[array.Length];

            
            Random rnd = new Random();
            
            for (int i = 0;  i < array.Length; i++)
            {
                int value = rnd.Next(-20, 21);
                if (Array.IndexOf(array1, value) != -1) continue;
                array[i] = value * (rnd.Next(0, 2) == 0 ? 1 : -1);
                array1[i] = value;
                
            }
            Console.Write("Массив: ");
            foreach (int element in array) Console.Write(element + " ");
            Console.WriteLine("");

            //Наибольшее по модулю число
            Console.WriteLine($"Наибольшее по модулю число: {array[Array.IndexOf(array1, array1.Max())]}");

        }
    }

}
    

