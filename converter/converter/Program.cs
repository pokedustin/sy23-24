using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < args.Length; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
