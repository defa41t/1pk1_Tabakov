using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo.Publications
{
    /*в этом же проекте реализуйте класс Journal (журнал) со следующими данными:
    дата издания, предметно-тематическая направленность журнала, название, количество страниц, цена 
    функционал класса:
    покупка журнала
    просмотр содержания журнала
     */
    internal class Journal
    {
        public string date; //дата
        public string orientation; //направленность
        public string name; //название
        public string countPages; //количество страниц
        public string price; //цена
        bool isBuy = true;
        bool isNotBuy = true;

        // метод класса - проверяет продан ли журнал
        public void Buy()
        {
            if (isBuy)
                Console.WriteLine($"Журнал {name} продан");
            
        }

        // метод класса - проверяет не продан ли журнал
        public void NotBuy()
        {
            if (isNotBuy)
                Console.WriteLine($"Журнал {name} не продан");
        }

        // метод класса - выдает информацию о газете
        public void JournalInfo()
        {
            Console.WriteLine($"\n\nЖурнал под названием {name} был написан в {date}, " +
                $"его предметно-тематическая направленность: {orientation}, количество страниц: {countPages}, и стоит он {price}");
        }
    }
}
