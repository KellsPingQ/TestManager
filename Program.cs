using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDll;

namespace TestManager
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string name = "Windows";

            Console.WriteLine("Hello TestManager.");
            HelloService.HelloDll();
            HelloService.HelloName(name);

            Console.ReadLine();
        }
    }
}
