namespace Task_21_09
{
    internal class Program
    {
        /*создайте класс билета (Ticket). сгенерируйте список из 30 билетов. произведите:
        • поиск билета с максимальной суммой,
        • билета с минимальной суммой,
        • выведите список билетов с багажом
        • выведите список люготных билетов
        */
        static void Main(string[] args)
        {
            Random random = new Random();
            List<Ticket> tickets = new List<Ticket>();

            // Генерация 30 билетов
            for (int i = 1; i <= 30; i++)
            {
                decimal price = random.Next(1000, 10000); // Случайная цена
                bool hasBaggage = random.Next(0, 2) == 1; 
                bool isDiscounted = random.Next(0, 2) == 1; 

                tickets.Add(new Ticket(i, price, hasBaggage, isDiscounted));
            }

            // Поиск билета с максимальной суммой
            var maxTicket = tickets.OrderByDescending(t => t.Price).First();
            Console.WriteLine("Билет с максимальной суммой:");
            Console.WriteLine(maxTicket);

            // Поиск билета с минимальной суммой
            var minTicket = tickets.OrderBy(t => t.Price).First();
            Console.WriteLine("\nБилет с минимальной суммой:");
            Console.WriteLine(minTicket);

            // Список билетов с багажом
            var ticketsWithBaggage = tickets.Where(t => t.HasBaggage).ToList();
            Console.WriteLine("\nСписок билетов с багажом:");
            foreach (var ticket in ticketsWithBaggage)
            {
                Console.WriteLine(ticket);
            }

            // Список люготных билетов
            var discountedTickets = tickets.Where(t => t.IsDiscounted).ToList();
            Console.WriteLine("\nСписок льготных билетов:");
            foreach (var ticket in discountedTickets)
            {
                Console.WriteLine(ticket);
            }
        }
    }
}
