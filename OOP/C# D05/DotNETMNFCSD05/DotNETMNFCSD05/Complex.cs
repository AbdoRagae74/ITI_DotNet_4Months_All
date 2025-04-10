using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETMNFCSD05
{
    class Complex
    {
        int real;
        int img;

        public int Real
        {
            get
            {
                return real;
            }

            set
            {
                real = value;
            }
        }

        public int Img
        {
            get
            {
                return img;
            }

            set
            {
                img = value;
            }
        }

        public Complex()
        {
            real = 3;
            img = 4;
        }
        public Complex(int _real,int _img)
        {
            real = _real;
            img = _img;
        }
        public string Print()
        {
            return $"{real}+{img}i";
        }

        public Complex Add(Complex right)
        {
            Complex result = new Complex();
            //
            return result;
        }

        #region Operators
        //c1+c2
        public static Complex operator +(Complex left,Complex right)
        {
            //#1
            //Complex result = new Complex();
            //result.real = left.real + right.real;
            //result.img = left.img + right.img;
            //return result;

            //#2
            //Complex result = new Complex//(left.real+right.real,left.img+right.img)
            //{
            //    Real=left.real+right.real,Img=left.img+right.img
            //};
            //return result; 

            //#3 [anonymous object]
            return new Complex { Real = left.real + right.real, Img = left.img + right.img };
        }

        //c1+10
        public static Complex operator +(Complex left ,int _num)
        {
            return new Complex
            {
                Real = left.real + _num,
                Img=left.img
            };
        }

        //10+c1
        public static Complex operator +(int _num,Complex left)
        {
            return new Complex
            {
                Real = left.real + _num,
                Img = left.img
            };

            return left + _num;
        }

        //c1++ or ++c1
        public static Complex operator ++(Complex left)
        {
            return new Complex
            {
                Real = left.real + 1,
                Img = left.img + 1
            };
        }

        //(int) c1
        public static implicit operator int(Complex left)
        {
            return left.real;
        }
        //(string)c1
        public static explicit operator string(Complex left)
        {
            return left.Print();
        }

        //c1>c2
        public static bool operator >(Complex left,Complex right)
        {
            return left.real > right.real && left.img > right.img;
        }
        public static bool operator <(Complex left, Complex right)
        {
            return left.real < right.real && left.img < right.img;
        }
        public static bool operator ==(Complex left, Complex right)
        {
            return left.real == right.real && left.img == right.img;
        }
        public static bool operator !=(Complex left, Complex right)
        {
            return !(left.real == right.real && left.img == right.img);
        }

        #endregion

    }
}
