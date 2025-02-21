using ClassesDemo.Publications;

namespace ClassesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            var book2 = new Book();
            var book3 = new Book() { title = "Автостопом по галактике", autor = "Дуглас Адамс" };
            Book book4 = new Book() { title = "Хоббит", autor = "Джон Толкин" };


            book1.autor = "Рей Бредберри";
            book1.title = "Марсианские хроники";
            book1.GetInfo();    //Рей Бредберри : Марсианские хроники

            book2.autor = "Джона Роулинг";
            book2.title = "Гарри Поттер и философский камень";
            book2.GetInfo();    //Джона Роулинг : Гарри Поттер и философский камень

            //выдача книги
            book2.GetBoot(); // книга выдана на неделю

            //попытка выдать уже занятую книгу
            book2.GetBoot(); // книга Гарри Поттер и философский камень в данный момент выдана другому читателю

            book1.ReturnBook(); // книга Марсианские хроники свободна
            
            



            var journal1 = new Journal() { name = "Техника и вооружение", countPages = "102 стр.", orientation = "военный", price = "930 рублей", date = "2025 г." };
            var journal2 = new Journal() { name = "Мурзилка", date = "2008 г.", price = "640 рублей", orientation = "детский", countPages = "52 стр." };

            journal1.JournalInfo(); // информация о первом журнале
            journal1.Buy(); // проверка на наличие первого журнала

            journal2.JournalInfo(); // информация о втором журнале
            journal2.NotBuy(); // проверка на наличие второго журнала


            var newspaper1 = new Newspaper() { name = "Известия", orientation = "Новостная", price = "25 рублей", publisher = "АО Редация газеты Известия" };
            var newspaper2 = new Newspaper() { name = "Московский комсомолец", orientation = "Социально-политическая", price = "30 рублей", publisher = "Московский издательский дом" };

            newspaper1.NewsInfo(); // информация о первой газете
            newspaper1.IsHave(); // проверка на наличие газеты

            newspaper2.NewsInfo(); // информация о второгой газете
            newspaper2.IsNotHave(); // проверка на наличие газеты
        }
    }
}
