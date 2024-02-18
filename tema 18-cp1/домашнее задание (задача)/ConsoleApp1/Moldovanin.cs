using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Класс молдованин
    /// </summary>
    class Moldovanin : Person
    {

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name"></param>
        public Moldovanin(string name)
        {
            this.Name = name;
        }


        /// <summary>
        /// Переопрделение метода приветствия
        /// </summary>
        public override void greeting()
        {
            Console.WriteLine($"Bună ziua, numele meu este {Name}");
        }




    }
}
