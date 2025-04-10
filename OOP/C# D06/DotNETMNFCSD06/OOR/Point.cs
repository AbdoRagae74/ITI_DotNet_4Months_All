using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOR
{
    class Point
    {
        int x;
        int y;

        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        //l2 call to construct start
        //l2 call to construct end
        public Point()
        {
            x = y = 0;
            Console.WriteLine("Point def ctor");
        }
        public Point(int _x,int _y)
        {
            x = _x;
            y = _y;
            Console.WriteLine("Point 2p ctor");
        }
        public string Print()
        {
            return $"({x},{y})";
        }
    }
}
