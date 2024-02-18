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

            DerivedClass der1 = new DerivedClass();
            der1.Method1();
            der1.Method2();
            der1.Method3();
            der1.Method4();
            Console.WriteLine();

            AClass class1 = new DerivedClass();
            class1.Method1();
            class1.Method2();
            class1.Method3();
            class1.Method4();

            Console.ReadKey();













        }
    }
}
