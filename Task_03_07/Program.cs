namespace Task_03_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double g = 9.8;
            double t = 0; 

            while (t <= 10)
            {
                double v = g * t;
                Console.WriteLine("t = " + t + "c, v = " + Math.Round(v, 1) + "м/c");
                t += 0.5;
            }
        }
    }
}
