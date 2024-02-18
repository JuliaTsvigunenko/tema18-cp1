using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Абстрактный класс Человек
    /// </summary>
    abstract class Person
    {

        /// <summary>
        /// поле имени
        /// </summary>
        private string name;

        public string Name { get { return name; } set { name = value; } }

        /// <summary>
        /// поле абстрактногго метода приветсвия
        /// </summary>
        public abstract void greeting();











    }
}
