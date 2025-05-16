using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOR
{
    class Geoshape
    {
        protected double dim1;
        protected double dim2;

        public double Dim1
        {
            get
            {
                return dim1;
            }

            set
            {
                dim1 = value;
            }
        }

        public double Dim2
        {
            get
            {
                return dim2;
            }

            set
            {
                dim2 = value;
            }
        }

        public Geoshape()
        {
            dim1 = dim2 = 0;
            Console.WriteLine("geo def ctor");
        }

        public Geoshape(double _dim1,double _dim2)
        {
            dim1 = _dim1; dim2 = _dim2;
            Console.WriteLine("geo 2p ctor");
        }
        public Geoshape(double _dim)
        {
            dim1 = dim2 = _dim;
            Console.WriteLine("geo def ctor");
        }
    }
    /////////////////////////////
    class Rect : Geoshape
    {
        //fields??? Nooooo

        public Rect()
        {
            //useless
            //dim1 = dim2 = 0;
            Console.WriteLine("Rect def ctor");
        }
        public Rect(double _d1,double _d2):base(_d1,_d2)
        {
            //dim1 = _d1;
            //dim2 = _d2;
            Console.WriteLine("Rect 2p ctor");
        }
        public double CArea()
        {
            return dim1 * dim2;
        }
    }
    ///////////////////////////////////////
    class Square : Geoshape
    {
        public Square()
        {
            Console.WriteLine("sq def ctor");
        }
        public Square(double _dim)//:base(_dim)
        {
            dim1 = dim2 = _dim;
        }
        public double CArea()
        {
            return dim1 * dim2;
        }
    }
    ////////////////////////////////////////
    class SquareV2 : Rect
    {
        public SquareV2()
        {
            
        }
        public SquareV2(double _dim):base(_dim,_dim)
        {
            //dim1 = dim2 = _dim;
        }


    }
    ///////////////////////////////////////
    class Circle:Geoshape
    {
        public Circle()
        {
            
        }
        public Circle(double _radius):base(_radius)
        {
            
        }
        public double CArea()
        {
            return Math.PI * dim1 * dim2;
        }

    }
    ///////////////////////////////////////////////////
    class Tri : Geoshape
    {
        public Tri()
        {
            
        }
        public Tri(double _base,double _height):base(_height,_base)
        {
            //dim1 = _base;
            //dim2 = _height;
        }
        public double CArea()
        {
            return 0.5 * dim1 * dim2;
        }
    }
}
