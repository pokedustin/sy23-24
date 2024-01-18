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
            Console.WriteLine("write your number");
            int num = 0;
            int.TryParse(Console.ReadLine(), out num);
            Console.WriteLine(num*12+" inches");
            Console.ReadLine();
            switch (num)
            {
                case 0: Console.WriteLine("");
                    break;
                default:
            }
        }
    }
}
