namespace Task_02_04
{
    internal class Program
    {
        /* Пользователь вводит свою дату рождения построчно (сначала год, потом месяц и в конце дату) произведите 
        расчет является ли пользователь совершеннолетним на текущую дату и выведите соответствующее сообщение об 
        этом
         */
        static void Main(string[] args)
        {
            Console.Write("Year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.Write("Month: ");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.Write("Day: ");
            int day = Convert.ToInt32(Console.ReadLine());

            DateTime birth = new DateTime(year, month, day);
            DateTime now = DateTime.Now;

            int age = now.Year - birth.Year;

            if (now.Month < birth.Month || now.Month == birth.Month && now.Day < birth.Day)
            {
                age--;
            }
            if (age >= 18)
            {
                Console.WriteLine("Совершеннолетний");
            }
            else
            { 
                Console.WriteLine("Несовершеннолетний");
            }
        }
    }
}
