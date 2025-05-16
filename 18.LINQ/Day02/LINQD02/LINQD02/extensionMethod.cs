using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQD02
{
    public static class extensionMethod
    {

        public static void loop<T>(this IEnumerable<T> e ) // Generic VS Dynamic
        {
            foreach(var item in e)
                Console.WriteLine(item);
            Console.WriteLine("******************************************");
        }
        
        public static void loopObject(this IEnumerable<dynamic> e )
        {

            foreach (var item in e)
            {
                Console.WriteLine(item.Key);
                foreach ( var item2 in item)
                    Console.WriteLine(item2);

                Console.WriteLine("******************************************");

            }

        }
    }
}
