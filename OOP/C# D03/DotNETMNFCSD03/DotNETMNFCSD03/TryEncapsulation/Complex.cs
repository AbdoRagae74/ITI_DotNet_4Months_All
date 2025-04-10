using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryEncapsulation
{
    class Complex
    {
        #region Data
        /*private*/
        int real;
        int img;
        #endregion
        #region Setters&getters   -> property
        //caller c1
        public void SetReal(int _real)
        {
            ///->validation
            /*caller*/real = _real;
        }
        public int GetReal()
        {
            return /*caller*/real;
        }
        public void SetImg(int _img)
        {
            img = _img;
        }
        public int GetImg()
        {
            return img;
        }
        #endregion
        #region Print
        public string Print()
        {
            return $"{real}+{img}i";
        }
        #endregion

        #region Add 2 Complex Numbers
        //caller c1
        public Complex Add(Complex left,Complex right)
        {
            Complex result = new Complex();
            result.real = left.real + right.real;
            result.img = left.img + right.img;
            return result;
        }

        //caller c1
        public Complex AddV2(Complex right)
        {
            Complex result = new Complex();
            result.real = /*caller*/real + right.real;
            result.img = /*caller*/img + right.img;
            return result;
        }
        #endregion
    }
}
