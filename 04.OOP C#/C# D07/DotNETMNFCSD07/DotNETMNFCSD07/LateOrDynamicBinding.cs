using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETMNFCSD07
{
    class Parent
    {
        protected int x;
        public int X
        {
            set { x = value; }
            get { return x; }
        }
        public Parent()
        {
            x = 0;
        }
        public Parent(int _x)
        {
            x = _x;
        }
        public virtual void Show()
        {
            Console.WriteLine("I'm Parent");
        }
    }
    //////////////////////////////////////////
    class Child : Parent
    {
        protected int y;
        public int Y
        {
            set { y = value; }
            get { return y; }
        }
        public Child()
        {
            y = 0;
        }
        public Child(int _x,int _y):base(_x)
        {
            y = _y;
        }
        public override void Show()
        {
            Console.WriteLine("I'm Child");
        }
    }
    //////////////////////////////////////////
    class SubChild:Child
    {
        protected int z;
        public int Z
        {
            set { z = value; }
            get { return z; }
        }
        public SubChild()
        {
            x = y = z = 0;
        }
        public SubChild(int _x,int _y,int _z)//:base(_x,_y)
        {
            x = _x;
            y = _y;
            z = _z;
        }
        public override void Show()
        {
            Console.WriteLine("I'm Sub Child");
        }
    }
}
