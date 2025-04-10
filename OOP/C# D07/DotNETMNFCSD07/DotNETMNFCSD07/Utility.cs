using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETMNFCSD07
{
    class Utility
    {
        //failure in Open close principle
        public static double SumOfAreasV1(Rect[] rarr, Square[] sarr, Tri[] tarr)
        {
            double sum = 0;
            for (int i = 0; i < rarr.Length; i++)
            {
                sum += rarr[i].CArea();
            }
            for (int i = 0; i < sarr.Length; i++)
            {
                sum += sarr[i].CArea();
            }
            for (int i = 0; i < tarr.Length; i++)
            {
                sum += tarr[i].CArea();
            }
            return sum;
        }

        //succeed in Open close principle
        public static double SumOfAreasV2(Geoshape[] garr)
        {
            double sum = 0;
            for (int i = 0; i < garr.Length; i++)
            {
                sum += garr[i].CArea();
            }
            return sum;
        }
    }
}
