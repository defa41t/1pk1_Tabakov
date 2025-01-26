namespace Task_04_10
{
    internal class Program
    {
        /*Заполнить массив из 10 элементов случайными числами в интервале [-10..10] и сделать реверс элементов 
        отдельно для 1-ой и 2-ой половин массива. Реверс реализовать через цикл. Стандартные методы класса Array
        использовать нельзя.
        Например, исходный массив: [5,2,-10,0,4,-6,7,2,9,-7]
        Результат: [4,0,-10,2,5,-7,9,2,7,-6]

         */
        static void Main(string[] args)
        {

            Random random = new Random();
            int[] array = new int[10];

            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-10, 11); 
            }

            // Вывод первоначального массива
            Console.WriteLine("Начальный массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            // Реверс первой половины массива
            for (int i = 0; i < array.Length / 2; i++)
            {
                int temp = array[i];
                array[i] = array[array.Length / 2 - 1 - i];
                array[array.Length / 2 - 1 - i] = temp;
            }

            // Реверс второй половины массива
            for (int i = array.Length / 2; i < (array.Length + (array.Length / 2)) / 2; i++)
            {
                int temp = array[i];
                array[i] = array[array.Length - 1 - (i - (array.Length / 2))];
                array[array.Length - 1 - (i - (array.Length / 2))] = temp;
            }

            // Вывод окончательного массива
            Console.WriteLine("Массив после реверса:");
            for (int g = 0; g < array.Length; g++)
            {
                Console.Write(array[g] + " ");
            }
            Console.WriteLine();
        }
    }
}
                
            

            
            
        
    

