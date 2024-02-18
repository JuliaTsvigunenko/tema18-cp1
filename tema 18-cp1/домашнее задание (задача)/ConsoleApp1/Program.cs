using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            //Создать абстрактный класс человек со св-ом: имя и метод приветсвия.
            //От этого класса наследуются другие три класса: русский, англичанин, молдованин. В них мы должны создать
            //конструктор и переопределить метод из абстрактногго класса с приветствием.


            //Создаем объекты разных национальностей 
            Russion russion = new Russion("Алексей");
            English english = new English("Adele");
            Moldovanin moldovanin = new Moldovanin("Ion");

            //Вызов метода приветствия 
            russion.greeting();
            english.greeting();
            moldovanin.greeting();

            Console.ReadKey();







        }
    }
}
