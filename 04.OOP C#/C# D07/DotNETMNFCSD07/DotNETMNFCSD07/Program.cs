namespace DotNETMNFCSD07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region var [Implicit typed variable] ==>Linq
            ////C# is strongly typed   int x;
            ////C# is type safety

            //var x = 22;
            //var str = "Sara";

            //var map = new Dictionary<int, string>();
            /////var query=select * from kaza where pk=value order by columnName 

            //var z; //compile error
            #endregion

            #region Early/Static Binding Example
            ////Parent p1 = new Parent(3);
            ////p1.Show();  //i'm parent
            ///////compiler retrieve show() copy that related to reference DT

            ////Child c1 = new Child(1, 2);
            ////c1.Show(); //i'm Child
            ///////compiler retrieve show() copy that related to reference DT
            /////


            //Parent p2 = new Child(1, 2);
            ////الأب يحتوي جميع ابنائه
            ////inheritance [is a]
            ////car is a viechle
            ////bus is a viechle
            ///
            ////????   viechle is a car
            //p2.Show();  //i'm Parent
            ///////compiler retrieve show() copy that related to reference DT

            //Child c2 = new SubChild(1, 2, 3);
            //c2.Show(); //i'm Child

            //Parent p3 = new SubChild(4, 5, 6);
            //p3.Show(); //i'm Parent

            #endregion

            #region Early/Static Binding Discuss  [Compile Time]
            ///when reference from parent references
            ///object from its childs
            ///and calling overridden fn
            ///Compiler will Early [compile time]
            ///retrieve fn copy that related to Reference DT
            ///NOT copy that related to object DT


            //Parent p1 = new SubChild(1, 2, 3);
            //p1.Show(); //i'm parent ?? Make sense ??? NOOOOO


            ///Sense
            ///when reference from parent references object from 
            ///its childs 
            ///when call overridden method
            ///it suppose for O.S to call fn that related to object
            ///

            ///can Be???YES
            ///if we make it Late Binding
            #endregion

            #region Late/Dynamic Binding Discuss  [Run Time]
            /////when reference from parent references
            /////object from its childs
            /////and calling overridden fn
            /////Compiler will Later [run time]
            /////retrieve fn copy that related to Object DT
            /////NOT copy that related to Reference DT
            /////
            //////How???
            /////1- fn to be overridden at fst level[parent] must be public and virtual
            /////2- overridden fn id child Data types must include keyword [override]
            /////3- make reference from parent that references object from its childs

            //Parent p1 = new Child();
            //p1.Show(); //i'm chld
            //Child c1 = new SubChild();
            //c1.Show(); //i'm sub c
            //Parent p2 = new SubChild();
            //p2.Show(); //i'm sub c

            #endregion

            #region Why Late Binding?
            //Rect[] rects = new Rect[]
            //{
            //    new Rect{Dim1=2,Dim2=5},
            //    new Rect{Dim1=3,Dim2=4},
            //    new Rect{Dim1=2,Dim2=5}
            //};
            //Square[] squares =
            //{
            //    new Square(10),
            //    new Square(10),
            //    new Square(10)
            //};

            ////Tri[] tris =
            ////{
            ////    new Tri(3,4),
            ////    new Tri(5,6),
            ////    new Tri(7,8)
            ////};

            ////Circle[] circles = {new Circle(7) };



            ////Console.WriteLine(Utility.SumOfAreasV1(rects,squares,tris));

            //Tri t1 = new Tri { Dim1 = 3, Dim2 = 4 };
            //Circle c1 = new Circle(7);

            //Geoshape[] geoshapes = { rects[0], rects[1], rects[2], squares[0], t1, c1 };

            //Console.WriteLine(Utility.SumOfAreasV2(geoshapes));

            #endregion

            #region Geoshape
            ////Geoshape g1 = new Rect(2, 5);
            ////Console.WriteLine(g1.CArea()); //10

            //Rect r1 = new Rect(5, 6);
            //Tri t1 = new Tri(2, 5);
            //Square s1 = new Square(10);

            //Geoshape[] geoshapes = { r1, t1, s1 };

            //Console.WriteLine(geoshapes[1].CArea());//5

            #endregion

            #region Notes
            ///virtual fn: late binding + fn can be overridden

            ///abstract class:
            ///class we cannot create object from it

            ///struct cannot inherit and cannot be inherited

            ///how to make virtual fn MUST BE overridden?
            ///if it became Abstract method

            ///Abstract method:
            ///>virtual fn that must be overridden otherwise [compile error]
            ///>abstract methos is method header only [without body]()
            ///>anstract method must exist inside abstract class

            ///>concrete class [normal class]

            ///>sealed class : class can inherit but cannot be inherited

            ///>IDE partial class: one Dt that its logic is
            ///distributed among several files

            ///Geoshape g;//= new Geoshape();
            #endregion

            #region Advanced C#
            ////All Dt in C# [built in] or [user defined]
            ///inhert from Base DT called class Object{}
            ///
            ///class Object{}
            ////Parent DT for Any DT in C#
            ///
            ///WHY????
            ///mutual Information
            ///
            //Object o1 = new Employee();
            ////Console.WriteLine(o1.ToString());
            //Console.WriteLine(o1.GetType().Name);
            //Employee e1 = new Employee();
            #endregion

            #region Lab starts 1.30 PM
            //1- try early vs late binding on
            //////parent , child ,subchild
            ///
            ///2- try SumOfAreas with 2 versions
            ///class geoshape and its child
            ////abstract class
            ////abstract method
            #endregion
        }
    }
}
