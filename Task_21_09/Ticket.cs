using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_21_09
{
    /*создайте класс билета (Ticket). сгенерируйте список из 30 билетов. произведите:
       • поиск билета с максимальной суммой,
       • билета с минимальной суммой,
       • выведите список билетов с багажом
       • выведите список люготных билетов
       */
    internal class Ticket
    {
        public int TicketId { get; set; }
        public decimal Price { get; set; }
        public bool HasBaggage { get; set; }
        public bool IsDiscounted { get; set; }

        public Ticket(int id, decimal price, bool hasBaggage, bool isDiscounted)
        {
            TicketId = id;
            Price = price;
            HasBaggage = hasBaggage;
            IsDiscounted = isDiscounted;
        }

        public override string ToString()
        {
            return $"Номер билета: {TicketId}, Сумма: {Price}, Наличие багажа: {HasBaggage}, Льгота: {IsDiscounted}";
        }
    }
}
