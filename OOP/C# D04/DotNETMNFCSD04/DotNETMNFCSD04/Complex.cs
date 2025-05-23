﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETMNFCSD04
{
    class Complex
    {
        #region Data Fields
        int real;
        int img;
        #endregion

        #region Setters & Getters
        //caller c2
        public void SetReal(/*Complex this,*/int _real)
        {
            real = _real;
        }
        public void SetImg(/*Complex this*/int _img)
        {
            this.img = _img;
        }
        public int GetReal(/*Complex this*/)
        {
            return real;
            return this.real;
        }
        public int GetImg(/*Complex this*/)
        {
            return img;
        }
        #endregion

        #region Print
        public string Print(/*Complex this*/)
        {
            return string.Format($"{real}+{this.img}i");
        }

        #endregion

        #region Add 2 Complex Numbers
        public Complex Add(/*Complex this*/Complex right)
        {
            Complex result = new Complex();
            result.real = this.real + right.real;
            result.img = /*caller this*/img + right.img;
            return result;
        } 
        #endregion

        #region Initialization Functions
        public void Initialize()
        {
            real = 3;
            this.img = 4;
        }
        public void Initialize(int _real,int _img)
        {
            real = _real;
            this.img = _img;
        }
        public void Initialize(int _num)
        {
            real=this.img=_num;
        }
        #endregion

        #region CTORS [inside class]
        ////default ctor [parameterless ctor] 
        ////generated by O.S if there is no ctor exists

        public Complex()
        {
            real = 3;
            this.img = 4;
        }
        public Complex(int _real, int _img)
        {
            real = _real;
            this.img = _img;
        }
        public Complex(int _num)
        {
            this.real = img = _num;
        }
        #endregion

        #region Dest
        //~Complex()
        //{
            
        //}
        #endregion
    }
}
