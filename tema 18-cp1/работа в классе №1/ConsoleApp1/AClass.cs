using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class AClass
    {


        //обычный метод

        public void Method1()
        {
            Console.WriteLine("Об.м.Method1 из абстрактного класса AClass");
        }

        public virtual void Method2()
        {
            Console.WriteLine("Об.м. Method2 из абстрактного класса AClass");
        }


        public abstract void Method3();
        public abstract void Method4();













    }
}
