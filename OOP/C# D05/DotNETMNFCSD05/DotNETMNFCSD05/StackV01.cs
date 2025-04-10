using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Mutable vs. Immutable
namespace DotNETMNFCSD05
{
    class MyStack
    {
        private int[] arr;//= new int[5];
        private int tos;//= 0;
        
        public MyStack()
        {
            arr = new int[5];
            tos = 0;
        }

        //Stack Functions
        public void Push(int value)
        {
            if (this.tos != 5)
            {
                arr[tos] = value;
                tos++;
            }
            else
            {
                Console.WriteLine("FULL!!!!");
            }
        }

        public int Pop()
        {
            int result=-12345;
            if(tos != 0)
            {
                tos--;
                result = arr[tos];
                //return result;
            }
            else
            {
                Console.WriteLine("EMPTY!!!");
                //return -1;  //NOT Effective
                //throw runtime error
            }
            return result;
        }



    }
}
