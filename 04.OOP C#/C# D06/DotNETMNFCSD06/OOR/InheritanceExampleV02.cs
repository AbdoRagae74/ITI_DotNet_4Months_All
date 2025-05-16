using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOR
{
    class Parent
    {
        protected int x;
        protected int y;

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

        //c2 call this ctor to initialize inherited members
        public Parent()
        {
            x = y = 0;
            Console.WriteLine("Parent def ctor");
        }
        //c2 call this ctor to initialize inherited members
        public Parent(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
        public int Sum()
        {
            return x + y;
        }
    }
    /////////////////////////////////////////
    //Child Dt inherits EVERYTHING from parent
    //ctor chaining 1- increase performance  2- reduce code written
    class Child : Parent
    {
        ///x,y,setx,sety,getx,gety,sumxy
        protected int z;

        public int Z
        {
            get
            {
                return z;
            }

            set
            {
                z = value;
            }
        }

        public Child()
        {
            z = 0;
            //useless
            //x = 0;
            //y = 0;
            Console.WriteLine("Child def ctor");
        }

        public Child(int _x, int _y, int _z):base(_x, _y)
        {
            //c2 x|1| y|2| z||
            z = _z;
            //c2 x|1| y|2| z|3|

            ////after ctor chaining [useless]
            //x = _x;
            //y = _y;
            Console.WriteLine("Child 2p ctor");
            //--->
        }

        public int Sum()
        {
            return x + y + z;
            return z + X + Y;
            //return z + this.Sum();  //stack overflow
            return z + base.Sum();  
        }
    }
}
