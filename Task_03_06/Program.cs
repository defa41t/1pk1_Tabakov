namespace Task_03_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double h = 0.5;

            for (double x = -4; x <= 4; x += h)
            {
                double y = Math.Abs(x);
                Console.WriteLine($"x = {x}, y = {y}");
            }
        }
    }
}
