using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelsAndStones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = new JewelsStonesClass();
            var y = x.CountJewelsInStones("Z", "ZZZZZ");
            Console.WriteLine(y);

            Console.ReadKey();
        }
    }
}
