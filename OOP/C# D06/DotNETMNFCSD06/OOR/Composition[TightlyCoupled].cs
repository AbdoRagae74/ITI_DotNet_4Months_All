using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOR
{
    ///Composition
    class Line
    {
        Point start = new Point();
        Point end = new Point();

        public Point Start
        {
            set { start = value; }
            get { return start; }
        }
        public Point End
        {
            set { end = value; }
            get { return end; }
        }

        public Line()
        {
            //start.x = 0;start.y = 0;  //compile Error Inaccessible

            ///l1  start x|0| y|0|  end  x|0| y|0| 
            //useless
            //start.X = 0;
            //start.Y = 0;
            //end.X = 0;
            //end.Y = 0;
            Console.WriteLine("Line def ctor");
        
        }

        public Line(int x1,int y1,int x2,int y2)
        {
            ///l2  start x|0| y|0|  end x|0| y|0| 
            start.X = x1;
            start.Y = y1;
            end.X = x2;
            end.Y = y2;
            ///l2  start x|1| y|2|  end x|3| y|4| 
            Console.WriteLine("Line 4p ctor");
        }

        public string Print()
        {
            return $"Line start{start.Print()}, end{end.Print()}";
        }

    }

    ///Composition
    class Rectangle
    {
        Point ul; 
        Point lr;

        public Point Ul
        {
            set { ul = value; }
            get { return ul; }
        }
        public Point Lr
        {
            set { lr = value; }
            get { return lr; }
        }

        public Rectangle()
        {
            ul = new Point();
            lr = new Point();
            //useless //ul.X = 0;ul.Y = 0;lr.X = 0;lr.Y = 0;
            Console.WriteLine("Rect def ctor");
        }
        public Rectangle(int x1,int y1,int x2,int y2)
        {
            ul = new Point();
            lr = new Point();
            ul.X = x1;
            ul.Y = y1;
            lr.X = x2;
            lr.Y = y2;
            Console.WriteLine("Rect 4p ctor");
        }
        public string Print()
        {
            return $"Rect ul{ul.Print()},lr{lr.Print()}";
        }
    }
}
