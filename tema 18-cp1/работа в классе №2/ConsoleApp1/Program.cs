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

            CClass c1 = new CClass();
            c1.Method1();
            Console.WriteLine();
            Console.WriteLine(c1.Method2(3, 4));
            Console.WriteLine();
            Console.WriteLine(c1.Method3("Привет,Юлия"));
            Console.WriteLine();
            c1.Print();

            Console.ReadKey();









        }
    }
}
