using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETMNFCSD04
{
    class Math
    {
        #region P01 overloading
        //public int Add(int left, int right)
        //{
        //    return left + right;
        //}

        //public int Add(int left, int middle, int right)
        //{
        //    return left + middle + right;
        //}

        //public string Add(string left, string right)
        //{
        //    return $"{left} {right}";
        //}

        //public int Add(int left, char right)
        //{
        //    return 22;
        //}
        //public int Add(char left, int right)
        //{
        //    return 22;
        //} 
        #endregion

        #region P02 default arguments V01
        //public int Add(int left=0, int middle=0,int right=0)
        //{
        //    return left + middle + right;
        //}
        /////in main()
        /////obj from Math
        /////cw obj.Add(1,2,3); //6
        /////cw obj.Add(1,2);   //3
        /////cw obj.Add(1);     //1
        /////cw obj.Add();      //0
        #endregion
        #region P02 default arguments V02
        //public int Add(int left, int middle = 0, int right = 0)
        //{
        //    return left + middle + right;
        //}
        /////in main()
        /////obj from Math
        /////cw obj.Add(_x:1,_z:2,_y:3); //6
        /////cw obj.Add(1,2);   //3
        /////cw obj.Add(1);     //1
        /////cw obj.Add();      //Compile error
        #endregion
        #region P02 default arguments V03
        //public int Add(int left, int middle, int right = 0)
        //{
        //    return left + middle + right;
        //}
        /////in main()
        /////obj from Math
        /////cw obj.Add(1,2,3); //6
        /////cw obj.Add(1,2);   //3
        /////cw obj.Add(1);     //Compile error
        /////cw obj.Add();      //Compile error
        #endregion
        #region P02 default arguments V04 WRONG
        //public int Add(int left, int middle = 0, int right)
        //{
        //    return left + middle + right;
        //}
        /////in main()
        /////obj from Math
        /////cw obj.Add(->
        #endregion
        #region Don't use default arguments with fn overloading despite it can be done here [c#]
        //public int Add(int left=0, int middle=0, int right=0)
        //{
        //    return left + middle + right;
        //}
        //public int Add(int left,int right)
        //{
        //    return left + right;
        //}
        /////in main()
        /////obj from Math
        /////cw obj.Add(1,2,3); 
        /////cw obj.Add(1); 
        /////cw obj.Add();

        ////cw  obj.Add(1,2);  //c++ =>Compile Error[Ambiguty]
        ////cw  obj.Add(1,2);  //c# => runs successfully  [WRONG]

        /////ابعدوا عن المشتبهات

        #endregion
    }
}