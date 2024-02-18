using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Класс русский человек
    /// </summary>
    class Russion : Person
    {

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="name"></param>
        public Russion(string name)
        {
            this.Name = name;
        }


        /// <summary>
        /// Переопрделение метода приветствия
        /// </summary>
        public override void greeting()
        {
            Console.WriteLine($"Привет, меня зовут {Name}");
        }






    }
}
