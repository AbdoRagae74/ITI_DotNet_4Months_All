﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOR
{
    //Aggregation/Association [Loosely coupled]
    class Triangle
    {
        Point p1;
        Point p2;
        Point p3;
        public Point P1
        {
            set { p1 = value; }
            get { return p1; }
        }
        public Point P2
        {
            set { p2 = value; }
            get { return p2; }
        }
        public Point P3
        {
            set { p3 = value; }
            get { return p3; }
        }

        public Triangle()
        {
            p1 = null;
            p2 = null;
            p3 = null;
            Console.WriteLine("Tri def ctor");
        }

        public Triangle(Point _p1,Point _p2,Point _p3)
        {
            p1 = _p1;
            p2 = _p2;
            p3 = _p3;
            Console.WriteLine("tri 3pnts ctor");
        }

        //public Triangle(int x1,int y1,int x2,int y2,int x3,int y3)
        //{ }
    }
}
