namespace Task_21_08
{
    internal class Program
    {
        /*напишите метод, который на вход получается массив параметров (строк) и возвращает только уникальные строки */
        static void Main(string[] args)
        {
            string[] strings = { "hello", "world", "programming", "C#", "world", "C#" };
            string[] uniqueStrings = GetStrings(strings);

            Console.WriteLine("Массив строк до: ");
            foreach (string s in strings) 
                Console.Write(s + ", ");
            Console.WriteLine();
            Console.WriteLine("Массив строк после: ");
            foreach(string i in uniqueStrings)
                Console.Write(i + ", ");
            
            
        }
        static string[] GetStrings(string[] strings)
        {
            HashSet<string> uniqueSet = new HashSet<string>(strings);
            return new string[uniqueSet.Count];
        }
    }
}
