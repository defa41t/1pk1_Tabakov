using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo.Publications
{
    /*в этом же проекте реализуйте класс Newspaper (газета) со следующими данными:
    дата издания, название газеты, заголовок главной полосы, количество страниц, цена
    функционал класса:
     */
    internal class Newspaper
    {
        public string name; // название
        public string publisher; // издатель
        public string orientation; // направленнность
        public string price; // цена
        bool isHave = true;
        bool isNotHave = true;

        public void NewsInfo()
        {
            Console.WriteLine($"\n\nГазета {name}, под издательством {publisher}, ее направленность: {orientation}, и стоит она {price}");
        }

        public void IsHave()
        {
            if ( isHave )
                Console.WriteLine($"Газеты {name} есть в наличии");
            else
                Console.WriteLine($"Газеты {name} закончились");
            
        }

        public void IsNotHave()
        {
            if (isNotHave)
                Console.WriteLine($"Газеты {name} закончились");
            else
                Console.WriteLine($"Газеты {name} есть в наличии");
        }
    }
}
