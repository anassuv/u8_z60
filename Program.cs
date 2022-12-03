using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] a = { { { 66, 27 }, { 25, 90 } },
                          { { 34, 26 }, { 41, 55 } } };

            Console.WriteLine();
            for (int k = 0; k <= a.GetUpperBound(0); k++)
            {
                for (int i = 0; i <= a.GetUpperBound(1); i++)
                {
                    for (int j = 0; j <= a.GetUpperBound(2); j++)
                    {
                        Console.Write("{0,5}({1},{2},{3})", a[i, j, k], i, j, k);
                    }
                    Console.WriteLine();
                }             
            }

            Console.ReadKey();
        }
    }
}
