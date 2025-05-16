using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETMNFCSD04
{
    struct Point
    {
        int x;
        int y;
        public void SetX(int _x)
        {
            x = _x;
        }
        public void SetY(int _y)
        {
            y = _y;
        }
        public int GetX()
        {
            return x;
        }
        public int GetY()
        {
            return y;
        }
        ///parametersless ctor exist implicitly or explicitly 
        ///despite if there are another ctors or not 
        //public Point()
        //{
        //    x = y = 0;
        //}

        public Point(int _x,int _y)
        {
            x = _x;
            y = _y;
        }
        public Point(int _num)
        {
            x = y = _num;
        }
        public string Print()
        {
            return $"({x},{y})";
        }
    }
}
