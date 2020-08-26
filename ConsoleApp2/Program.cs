using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print();
            int result = Add(5,10);
            Console.WriteLine(result);
            Console.ReadLine();

        }

        static void Print()
        {
            Console.WriteLine("Hello World");
            Console.ReadLine();
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

    }
}
