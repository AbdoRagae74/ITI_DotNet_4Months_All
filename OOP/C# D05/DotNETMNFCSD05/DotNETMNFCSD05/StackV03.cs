using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETMNFCSD05
{
    class StackStr
    {
        string[] arr;
        int tos;
        int size;

        public StackStr()
        {
            size = 5;
            tos = 0;
            arr = new string[size];
        }
        public StackStr(int _size)
        {
            size = _size;
            tos = 0;
            arr = new string[size];
        }

        #region Stack Functions
        public void Push(string value)
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

        public string Pop()
        {
            string result=default;
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
    //
    class StackChar
    {
        char[] arr;
        int tos;
        int size;

        public StackChar()
        {
            size = 5;
            tos = 0;
            arr = new char[size];
        }
        public StackChar(int _size)
        {
            size = _size;
            tos = 0;
            arr = new char[size];
        }

        #region Stack Functions
        public void Push(char value)
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

        public char Pop()
        {
            char result = default;
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
    //
    //infinity

}
