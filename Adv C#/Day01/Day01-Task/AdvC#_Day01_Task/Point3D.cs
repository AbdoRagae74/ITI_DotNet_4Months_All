using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvC__Day01_Task
{
    internal class Point3D
    {

        //Task 1
        
            private int x, y, z;
            public int X { get { return x; } set { x = value; } }
            public int Y { get { return y; } set { y = value; } }
            public int Z { get { return z; } set { z = value; } }

            public Point3D(int x = 0, int y = 0, int z = 0)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }
            public override string ToString()
            {
                return $"Point Coordinates : ({x},{y},{z})";
            }
        public override bool Equals(object? obj)
        {
            Point3D p = (Point3D) obj;
            return x == p.X && y == p.Y && z == p.Z ;
        }



    }
}
