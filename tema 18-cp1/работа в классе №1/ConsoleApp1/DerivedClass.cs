using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DerivedClass : AClass
    {

        public override void Method2()
        {
            base.Method2();
            Console.WriteLine("Метод Method2 из класса AClass, реализованный в классе DarivedClass");
        }
        public override void Method3()
        {
            Console.WriteLine("Метод Method3 из класса AClass,  реализованный в классе DarivedClass");
        }

        public override void Method4()
        {
            Console.WriteLine("Метод Method4 из класса AClass, реализованный в классе DarivedClass");
        }





    }
}
