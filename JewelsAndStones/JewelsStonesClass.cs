using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelsAndStones
{
    internal class JewelsStonesClass
    {
        public int CountJewelsInStones(string jewels, string stones)
        {
            int result = 0;

            foreach(char c in stones)
            {
                foreach(char c2 in jewels)
                {
                    if(c == c2) result++;
                }
            }

            return result;
        } 
    }
}
