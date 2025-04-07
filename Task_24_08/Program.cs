namespace Task_24_08
{
    internal class Program
    {
        /*реализуйте функцию, осуществляющую поиск текста в файле 
         * и его замену на значения, введенные пользователем
         */
        static void Main(string[] args)
        {
            string path = "text.txt";

            Console.Write("Введите текст для поиска: ");
            string searchText = Console.ReadLine();

            Console.Write("Введите текст для замены: ");
            string replacementText = Console.ReadLine();

            // Чтение содержимого
            string fileContent = File.ReadAllText(path);

            // Выполнение замены
            string updatedContent = fileContent.Replace(searchText, replacementText);

            // Сохранение изменении
            File.WriteAllText(path, updatedContent);
        }
    }
}
