using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Rand
{
    

    internal class Rand
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int val;
            for(int i = 0; i < 10; i++)
            {
                val = rand.Next(0, 11);
                WriteLine(val);
                ReadKey();
            }
        }
    }
}