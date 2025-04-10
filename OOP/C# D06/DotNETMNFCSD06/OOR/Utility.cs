using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOR
{
    class Utility
    {
        public static void PrintArrayV(int[] param)
        {
            param = new int[] { 66, 77, 88, 99, 110 };
            Console.WriteLine($"Function param identity {param.GetHashCode()}");
            for (int i = 0; i < param.Length; i++)
            {
                Console.WriteLine(param[i]);
            }
            Console.WriteLine("modify in fn index 0");
            param[0] = -100;
        }

        public static void PrintArrayR(ref int[] param)
        {
            param = new int[] { 55, 66, 77, 88, 99 };
            Console.WriteLine($"Function param identity {param.GetHashCode()}");
            for (int i = 0; i < param.Length; i++)
            {
                Console.WriteLine(param[i]);
            }
            Console.WriteLine("modify in fn index 0");
            param[0] = -100;
        }

    }
}
