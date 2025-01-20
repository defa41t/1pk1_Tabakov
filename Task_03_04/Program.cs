namespace Task_03_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            while (true) 
            {
            Console.Write("Ввести данные: ");
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
