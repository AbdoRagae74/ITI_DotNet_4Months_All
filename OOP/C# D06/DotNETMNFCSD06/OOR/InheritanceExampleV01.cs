using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOR
{
    //class Parent
    //{
    //    int x;
    //    int y;
       
    //    public int X
    //    {
    //        get
    //        {
    //            return x;
    //        }

    //        set
    //        {
    //            x = value;
    //        }
    //    }

    //    public int Y
    //    {
    //        get
    //        {
    //            return y;
    //        }

    //        set
    //        {
    //            y = value;
    //        }
    //    }

    //    //c2 call this ctor to initialize inherited members
    //    public Parent()
    //    {
    //        x = y = 0;
    //        Console.WriteLine("Parent def ctor");
    //    }
    //    public Parent(int _x,int _y)
    //    {
    //        x = _x;
    //        y = _y;
    //    }
    //    public int SumXY()
    //    {
    //        return x + y;
    //    }
    //}
    ///////////////////////////////////////////
    ////Child Dt inherits EVERYTHING from parent
    //class Child:Parent
    //{
    //    ///x,y,setx,sety,getx,gety,sumxy
    //    int z;

    //    public int Z
    //    {
    //        get
    //        {
    //            return z;
    //        }

    //        set
    //        {
    //            z = value;
    //        }
    //    }

    //    public Child()
    //    {
    //        ////c1 x|0| y|0| z|?|
    //        z=0; //T
    //        ////c1 x|0| y|0| z|0|
    //        ////x=0;y=0; //compile error inaccessible
    //        ////useless
    //        //X = 0;
    //        //Y = 0;
    //        Console.WriteLine("Child def ctor");
    //    }

    //    public Child(int _x,int _y,int _z)
    //    {
    //        //c2 x|0| y|0| z|?|
    //        z = _z;
    //        //c2 x|0| y|0| z|3|
    //        X = _x;
    //        Y = _y;
    //        //c2 x|1| y|2| z|3|
    //        Console.WriteLine("Child 2p ctor");
    //        //--->
    //    }

    //    public int SumXYZ()
    //    {
    //        //return z + x + y;
    //        return z + this.X + this.Y;
    //    }
    //}

}
