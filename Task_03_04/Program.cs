namespace Task_03_04
{
    internal class Program
    {
        /*Пользователь вводить в консоли произвольный текст. После каждого ввода консоль очищается. Когда 
        пользователь вводить слово «exit» или пустую строку – ввод останавливается и выводиться количество строк 
        введенных пользователем.
        */
        static void Main(string[] args)
        {
            int count = 0;

            while (true) 
            {
            Console.Write("Ввести данные(введите exit или оставьте строку пустой, если хотите завершить): ");
            string text = Console.ReadLine();
            Console.Clear();
                
                if (text == "exit" ||  text == "")
                break;
                count++;
            }
            Console.WriteLine("Количество строк: " + count);
        }
    }
}
