using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Класс англичанин
    /// </summary>
    class English : Person
    {

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name"></param>
        public English(string name)
        {
            this.Name = name;
        }


        /// <summary>
        /// Переопрделение метода приветствия
        /// </summary>
        public override void greeting()
        {
            Console.WriteLine($"Hello, my name is {Name}");
        }











    }
}
