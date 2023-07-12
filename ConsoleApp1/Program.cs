using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        delegate int referance(int n);
        static void Main(string[] args)
        {
            Console.WriteLine(sum(8));
            Console.WriteLine(mult(8));

            referance info = new referance(sum);
            Console.WriteLine(info(4));

            referance inf2 = new referance(mult);
            Console.WriteLine(inf2(4));
        }

        static int sum(int a)
        {
            return a + 10;
        }

        static int mult(int a)
        {
            return a * 10;
        }
    }
}
