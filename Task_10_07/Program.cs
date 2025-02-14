namespace Task_10_07
{
    internal class Program
    {
        /*Создайте метод с помощью которого можно сгенерировать 
         * и вернуть символьный двумерныймассив(состоящий из символов русского алфавита) 
         * и выведите на консоль данный массив с помощью другого метода(который принимает
         * данный массив в качестве параметра)
         */
        static void Main(string[] args)
        {
            //Создаем двумерный массив
            char[,] array = ArrayChars(5, 5);
            
            //Вывод массива
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static char[,] ArrayChars(int rows, int columns)
        {
            //Заполнение массива
            char[,] result = new char[rows, columns];
            char[] Alphabet = "абвгджеёжзийклмнопрстуфхцчшщъыьэюя".ToCharArray();
            Random rnd = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = Alphabet[rnd.Next(Alphabet.Length)];
                }

            }
            return result;
        }
    }
}
