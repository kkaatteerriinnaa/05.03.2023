using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T c = a;
            a = b;
            b = c;
            Console.WriteLine(a + " " + b);
        }
        static void Main(string[] args)
        {
            int a = 1, b =5;
            Swap(ref a, ref b);

        }
    }
}
