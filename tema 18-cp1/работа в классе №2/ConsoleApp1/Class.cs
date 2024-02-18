using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Наследуемый от класса CClass
    /// </summary>
    abstract class Class : CClass
    {

        /// <summary>
        /// метод из класса AClass
        /// </summary>
        public override void Method1()
        {
            Console.WriteLine("Method1");
        }


        /// <summary>
        /// метод из класса BClass
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public override int Method2(int a, int b)
        {
            return a + b;
        }


        /// <summary>
        /// метод из класса CClass
        /// </summary>
        public override string Method3(string hello)
        {
            return hello;
        }



        public void Print()
        {
            Console.WriteLine("Обычный метод");
        }












    }
}
