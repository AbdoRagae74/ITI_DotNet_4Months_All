using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETMNFCSD05
{
    class DynamicStack
    {
        int[] arr;
        int tos;
        int size;
        //this line of code is executed once per program call
        private static int counter=0; //later -> static ctor fn to initialize static members   
        
        public static int GetCounter()
        {
            return counter;
        }

        public static int Counter
        {
            get
            {
                return counter;
            }
        }
        
        public DynamicStack()
        {
            counter++;
            size = 5;
            tos = 0;
            arr = new int[size];
        }
        public DynamicStack(int _size)
        {
            counter++;
            size = _size;
            tos = 0;
            arr = new int[size];
        }

        #region Stack Functions
        public void Push(int value)
        {
            //if (this.tos != size)
            if (!IsFull())
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
            int result = -12345;
            //if (tos != 0)
            if (!IsEmpty())
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

        public bool IsFull()
        {
            return tos == size;
        }

        public bool IsEmpty()
        {
            return this.tos == 0;
        }


        #endregion
    }
}
