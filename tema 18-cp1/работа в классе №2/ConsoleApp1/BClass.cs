using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Абстрактный класс BClass наследуемый от класса AClass
    /// </summary>
    abstract class BClass : AClass
    {

        /// <summary>
        /// Абстрактный класс для сложения двух чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public abstract int Method2(int a, int b);




    }
}
