namespace OOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region OOR
            //Object Oriented Relations
            //Relation between classes   Employee  ,Student ,Instructor ,Department

            //1-Composition [Tightly Coupled]
            //class Contains All Of Another class

            //2-Aggregation [loosely coupled]
            //class may contains another class later

            //3-Association [Very Loosely coupled]
            //peer to peer each class may not depend on
            //another one 

            //4- inheritance
            ////////////////////////////////////////////////////
            //A-Association [Very Loosely coupled]
            ///1- Peer-To-Peer
            //teacher    subject
            ///2- Temporarily relation
            ///3- represent in code
            //c++ Pointer of class inside another class
            //C# Reference  of class inside another class
            ///class Teacher
            //{
            //id,name,age
            //Subject sub; //null
            //};
            ///class Subject
            //{
            //id,name,age
            //Teacher tch; //null
            //};
            //4- 1-0 1-1  1-M M-M 
            //5- No Dependency


            //B-Aggregation [loosely coupled]
            ///1- Whole vs. part
            ///      Student       Department
            ///2- temp. Relation
            ///3- Represent in code
            ///c++ Pointer of class inside another class
            //C# Reference of class inside another class
            ///class Student
            //{
            //id,name,age
            //Department Dept;//null
            //ctor(){new dept[10]}
            //};
            ///4- 1-0 1-1   1-M M-M
            ///5- No Dependency


            //C- Composition [Tightly Coupled]
            ///1- complete ownership [has a]
            ///2- Permenant relationship
            //Room    wall
            ///3- object of class inside another class
            ///class Room
            //{
            //Wall  w1=new Wall();
            //Wall  w2=new Wall();
            //Wall  w3=new Wall();
            //Wall  w4=new Wall();

            //};
            ///main  room r[10] ||||||||
            //room r1,r2,r3
            ///4- 1-1 1-m 
            ///5- Complete Dependency



            ///SOLID



            //Dependency Inversion:
            ///Principle of how to create 
            ///loosely coupled application


            ///SOLID

            //principle
            //Concept
            //Framework


            #endregion

            #region Composition Example
            //Line l1 = new Line();
            ////o/p
            ////point def ctor start
            ////point def ctor end
            ////line def ctor
            /////
            //Line l2 = new Line(1, 2, 3, 4);
            //Console.WriteLine(l2.Print());

            //Rectangle r1 = new Rectangle();
            ////o/p
            ////point def ctor ul
            ////point def ctor lr
            ////rect def ctor

            //Rectangle r2 = new Rectangle(1, 2, 3, 4);

            #endregion

            #region Aggregation/Association Example

            ////Object from triangle withot depend on points

            //Point pnt1 = new Point { X = 3, Y = 4 };
            //Point pnt2 = new Point { X = 5, Y = 6 };
            //Point pnt3 = new Point { X = 7, Y = 8 };

            //Triangle t1 = new Triangle();
            ////o/p
            ////tri def ctor ONLY

            ////set relationship bet. tri and those points
            //t1.P1 = pnt1;
            //t1.P2 = pnt2;
            //t1.P3 = pnt3;

            ////print
            ////cw t1.print()

            ////Remove relationship bet. tri and those points 
            //t1.P1 = null;
            //t1.P2 = null;
            //t1.P3 = null;



            //Triangle t2 = new Triangle(pnt1, pnt2, pnt3);

            ////print

            ////Remove relationship bet. tri and those points 
            //t2.P1 = null;
            //t2.P2 = null;
            //t2.P3 = null;

            ///SOLID
            /////->Dependency injection
            #endregion

            #region Pass RT By Value === pass by Ref [Temporarily]
            //int[] arr = [1, 2, 3, 4, 5];
            //Console.WriteLine($"MAIN arr {arr.GetHashCode()}");
            //Utility.PrintArrayV(arr);
            #endregion

            #region Pass RT By Reference === Alias name Permenant
            //int[] arr = [1, 2, 3, 4, 5];
            //Console.WriteLine($"MAIN arr {arr.GetHashCode()}");
            //Utility.PrintArrayR(ref arr);
            //Console.WriteLine($"finished fn arr {arr.GetHashCode()}");

            #endregion

            #region Inheritance
            //Inheritance:
            ///extend properties and methods from Dt to another one
            ///new DT has properties and method gained from another DT
            ///

            ///TypeA
            /////x
            /////y
            /////FunOne()
            /////FunTwo()

            ///TypeB
            /////y
            /////z
            /////FunTwo()
            /////FunThree()

            ///Base
            /////y
            /////FunTwo()

            ///TypeA inherits Base
            /////x
            /////FunOne()

            ///TypeB inherits Base
            /////z
            /////FunThree()
            #endregion

            #region RULES
            ///private:member can be accessed inside class ONLY
            ///public:member can be accessed inside and outside class[object name]
            ///Child DT Inherits EVERYTHING from Parent private or public =>except ctor,static
            #endregion

            #region Inheritance Example V01
            ////Parent p1 = new Parent();  //8B  x|0| y|0|

            ////Child c1 = new Child();    //12B  x|0| y|0|  z|?|
            //////o/p
            //////parent def ctor
            //////child def ctor
            /////
            //Child c2 = new Child(1, 2, 3);
            ////o/p
            /////parent def ctor
            /////child 3p ctor
            //Console.WriteLine(c2.SumXYZ());//6
            //Console.WriteLine(c2.SumXY());//3

            #endregion

            #region protected [Inheritance]
            ///private member is inherited but cannot be accessed
            ///is there any way to access private members inside child DT?
            ///YES -> if we canged them to [protected]
            ///
            ///protected [smart private]
            ///member can be accessed
            ///inside class scope
            ///and accessed inside chain of inheritance   
            ///ONLY
            #endregion

            #region Inheritance Example V02
            ////Parent p1 = new Parent();
            ////p1.x = 22;  //compile error //inaccesseible  //protected


            //Child c2 = new Child(1, 2, 3);
            //Console.WriteLine(c2.Sum());//6
            ////Console.WriteLine(c2.Sum());//3 //No way  //not make sense C#    //c++  cout<< c2.Parent::Sum();
            #endregion

            #region Overriding [Inheritance]
            //fn overriding
            //fn has same name ,and same parameters
            //but body/implementation is different in child DT
            #endregion

            #region Inheritance Example V03
            ////Rect r1 = new Rect(3,4);
            //////o/p
            //////geo ctor
            //////rect ctor
            ////Console.WriteLine(r1.CArea());

            //SquareV2 s1 = new SquareV2(10);
            ////o/p
            ////geo ctor
            ////rect ctor
            ////sq ctor
            #endregion

            #region Lab Assignmets
            
            //1- Composition vs. Association 
            //on class Point, line,rect,circle,tri
            
            //2- inheritance,protected ,overriding
            //on geoshape,rect,sq,sqv2,cir,tri
            #endregion
        }
    }
}
