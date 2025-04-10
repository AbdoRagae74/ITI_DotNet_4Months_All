using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETMNFCSD04
{
    class Utility
    {
        public void SwapV(int left,int right)
        {
            int tmp;
            tmp = left;
            left = right;
            right = tmp;
        }
        public void SwapR(ref int left,ref int right)
        {
            int tmp;
            tmp = left;
            left = right;
            right = tmp;
        }

        public void PrintArrayV(int[] param)
        {
            int[] arr = [10, 20, 30, 40, 50];
            Console.WriteLine($"Function param identity {param.GetHashCode()}");
            for (int i = 0; i < param.Length; i++)
            {
                Console.WriteLine(param[i]);
            }
            Console.WriteLine("modify in fn index 0");
            param[0] = -100;
        }

        public void PrintArrayR(ref int[] param)
        {
            Console.WriteLine($"Function param identity {param.GetHashCode()}");
            for (int i = 0; i < param.Length; i++)
            {
                Console.WriteLine(param[i]);
            }
            Console.WriteLine("modify in fn index 0");
            param[0] = -100;
        }

        public static void x(ref string y)
        {
            y = "gdfgf";
        }


    }
}
