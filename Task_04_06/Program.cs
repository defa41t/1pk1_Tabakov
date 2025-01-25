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
            
            int array = 20;
            int[] nums = new int[array];
            Random rnd = new Random();
            HashSet<int> abs = new HashSet<int>();

            int index = 0;
            while (index < array)
            {
                int randNum = rnd.Next(-100, 101);

                //Предотвращаем повторение
                if (abs.Add(Math.Abs(randNum)))
                {
                    nums[index] = randNum;
                    
                }
                index++;
            }

            Console.Write("Сгенерированный массив: ");
            foreach (var number in nums)
            {
                Console.Write(number + " ");
            }

            // Поиск наибольшего по модулю числа
            int maxAbsValue = nums[0];
            foreach (var number in nums)
            {
                if (Math.Abs(number) > Math.Abs(maxAbsValue))
                {
                    maxAbsValue = number;
                }
            }

            Console.WriteLine($"\nНаибольшее по модулю число: {maxAbsValue}");
            
        }
    }

}
    

