using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETMNFCSD05
{
    class GenericStack<EI>
    {
        EI[] arr;
        int tos;
        int size;

        public GenericStack()
        {
            size = 5;
            tos = 0;
            arr = new EI[size];
        }
        public GenericStack(int _size)
        {
            size = _size;
            tos = 0;
            arr = new EI[size];
        }

        #region Stack Functions
        public void Push(EI value)
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

        public EI Pop()
        {
            EI result =default;
            //if (tos != 0)
            if (!IsEmpty())
            {
                tos--;
                result = arr[tos];
                return result;
            }
            else
            {
                Console.WriteLine("EMPTY!!!");
                //return -1;  //NOT Effective
                //throw runtime error
                //throw new Exception();
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
