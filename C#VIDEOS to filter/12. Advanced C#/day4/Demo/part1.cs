using System.Collections;
using System.Diagnostics;
using System.Net.Sockets;
using System.Text;

namespace Day4
{

    //class test<t>
    //{
    //    public t MyProperty { get; set; }
    //}
    //class myclas:test<int>
    //{

    //}
    enum gender
    {
        male ,female
    }
    [Flags]
    enum pervilage:byte
    {
        supervisor=1 ,student=2, admin=4,leader=8 ,TM=16 
    }
    class subjectlist : List<Subject>
    {
        public override string ToString()
        {
            //string txt = "";
            //foreach (Subject s in this)
            //{
            //    txt += s.ToString() + "\n";
            //}
            //return txt;
            StringBuilder st = new StringBuilder();
            foreach (Subject s in this)
            {
                st.Append(s.ToString());
            }
            return st.ToString();
        }
    }
    class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public pervilage myprev { get; set; }
        public Student(int id = 0, string name = "", int age = 0,pervilage myprev=pervilage.student)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.myprev = myprev;
        }
        public override string ToString()
        {
            return $"{id}-{name}-{myprev} \t {age}years old";
        }


    }
    class Subject
    {
        public int id { get; set; }
        public string name { get; set; }
        public int duration { get; set; }
        public Subject(int id = 0, string name = "", int duration = 12)
        {
            this.id = id;
            this.name = name;
            this.duration = duration;
        }
        public override string ToString()
        {
            return $"{id}-{name} \t {duration}Hours";
        }





    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region enum
            //gender g = gender.male;
            //Console.WriteLine(g);

            //pervilage p = pervilage.leader;
            //pervilage p = (pervilage)101;
            //Console.WriteLine(p);
            //pervilage p = pervilage.student ^ pervilage.leader ^pervilage.supervisor ;
            //Console.WriteLine(p);

            //Student s = new Student(1, "ali", 22, pervilage.leader);
            //Console.WriteLine(s);
            #endregion
            #region  collection
            // ArrayList sts = new ArrayList() { 2,"ali",2.2f,23};
            // sts.Add(1);//index 4
            // sts.Add("ali");//index 5
            // sts.AddRange(new int[] { 3, 2, 5, 6, 7 });
            // //  Console.WriteLine(sts.Count);
            // //  sts[1] = "mostafa";

            ////  sts.Remove(2);
            // sts.RemoveRange(2, 3);
            // // Console.WriteLine(sts[0]);
            // // sts.RemoveAt(7);
            // // Console.WriteLine(sts.Capacity);
            // ////
            // foreach (object obj in sts)
            // {
            //     Console.WriteLine(obj);
            // }



            #endregion
            #region  generic.collection
            //List<int> li = new List<int>() { 2,3,4,5};
            //li.Add(1);
            //Console.WriteLine(li.Count);
            //foreach (int i in li)
            //{
            //    Console.WriteLine(i);
            //}

            //List<Student> sts = new List<Student>();
            //sts.Add(new Student(1, "mostafa", 22, pervilage.student));
            //sts.Add(new Student(2, "mona", 22, pervilage.student));
            //sts.Add(new Student(3, "ahmed", 22, pervilage.student));

            //foreach (Student s in sts)
            //{
            //    Console.WriteLine(s);
            //}

            //  Dictionary<string, string> dic = new Dictionary<string, string>();
            //  dic.Add("ahmed mohamed", "3 dhdhdh street ,dhgffg,cairo");
            //  dic.Add("mona", "4 dhdhdh street ,dhgffg,monufia");
            //  dic.Add("mona", "8 dhdhdh street ,dhgffg,alex");
            //  dic["mostafa"] = "5 dhdhdh street ,dhgffg,tanta";
            ////  Console.WriteLine(dic["mostafa"]);

            //  //foreach(KeyValuePair<string,string> item in dic)
            //  //{
            //  //    Console.WriteLine(item.Key);
            //  //    Console.WriteLine(item.Value);
            //  //}

            //  foreach(string k in dic.Values)
            //  {
            //      Console.WriteLine(k);
            //  }

            //List<Subject> subj1 = new List<Subject>()
            //{
            //    new Subject(1,"C#",22),
            //    new Subject(2,"SQL",24),
            //    new Subject(3,"LINQ",20)
            //};

            //Dictionary<Student, List<Subject>> dic = new Dictionary<Student, List<Subject>>();
            //dic.Add(new Student(1, "ali ahmed", 22, pervilage.student), subj1);
            //dic.Add(new Student(2, "mostafa", 20, pervilage.student), new List<Subject>() {
            // new Subject(1,"html",22),
            //    new Subject(2,"js",24),
            //    new Subject(3,"html5",20),
            //    new Subject(3,"angular",20)

            //});
            //dic.Add(new Student(3, "ola", 22, pervilage.student), subj1);

            //foreach(KeyValuePair<Student ,List<Subject>> item in dic)
            //{
            //    Console.WriteLine(item.Key);
            //    Console.WriteLine("subjects:");
            //    foreach(Subject s  in item.Value)
            //    {
            //        Console.WriteLine(s);
            //    }
            //    Console.WriteLine("----------------");
            //}


            //List<Subject> sts = new List<Subject>();
            //Console.WriteLine(sts);

            subjectlist st = new subjectlist()
            {
                    new Subject(1,"html",22),
                new Subject(2,"js",24),
                new Subject(3,"html5",20),
                  new Subject(2,"js",24),
                new Subject(3,"html5",20),
                  new Subject(2,"js",24),
                new Subject(3,"html5",20),
                  new Subject(2,"js",24),
                new Subject(3,"html5",20),
                  new Subject(2,"js",24),
                new Subject(3,"html5",20),
                  new Subject(2,"js",24),
                new Subject(3,"html5",20),
                   new Subject(1,"html",22),
                new Subject(2,"js",24),
                new Subject(3,"html5",20),
                  new Subject(2,"js",24),
                new Subject(3,"html5",20),
                  new Subject(2,"js",24),
                new Subject(3,"html5",20),
                  new Subject(2,"js",24),
                new Subject(3,"html5",20),
                  new Subject(2,"js",24),
                new Subject(3,"html5",20),
                  new Subject(2,"js",24),
                new Subject(3,"html5",20),
                   new Subject(1,"html",22),
                new Subject(2,"js",24),
                new Subject(3,"html5",20),
                  new Subject(2,"js",24),
                new Subject(3,"html5",20),
                  new Subject(2,"js",24),
                new Subject(3,"html5",20),
                  new Subject(2,"js",24),
                new Subject(3,"html5",20),
                  new Subject(2,"js",24),
                new Subject(3,"html5",20),
                  new Subject(2,"js",24),
                new Subject(3,"html5",20),
                   new Subject(1,"html",22),
                new Subject(2,"js",24),
                new Subject(3,"html5",20),
                  new Subject(2,"js",24),
                new Subject(3,"html5",20),
                  new Subject(2,"js",24),
                new Subject(3,"html5",20),
                  new Subject(2,"js",24),
                new Subject(3,"html5",20),
                  new Subject(2,"js",24),
                new Subject(3,"html5",20),
                  new Subject(2,"js",24),
                new Subject(3,"html5",20),
                   new Subject(1,"html",22),
                new Subject(2,"js",24),
                new Subject(3,"html5",20),
                  new Subject(2,"js",24),
                new Subject(3,"html5",20),
                  new Subject(2,"js",24),
                new Subject(3,"html5",20),
                  new Subject(2,"js",24),
                new Subject(3,"html5",20),
                  new Subject(2,"js",24),
                new Subject(3,"html5",20),
                  new Subject(2,"js",24),
                new Subject(3,"html5",20),
                   new Subject(1,"html",22),
                new Subject(2,"js",24),
                new Subject(3,"html5",20),
                  new Subject(2,"js",24),
                new Subject(3,"html5",20),
                  new Subject(2,"js",24),
                new Subject(3,"html5",20),
                  new Subject(2,"js",24),
                new Subject(3,"html5",20),
                  new Subject(2,"js",24),
                new Subject(3,"html5",20),
                  new Subject(2,"js",24),
                new Subject(3,"html5",20),
                   new Subject(1,"html",22),
                new Subject(2,"js",24),
                new Subject(3,"html5",20),
                  new Subject(2,"js",24),
                new Subject(3,"html5",20),
                  new Subject(2,"js",24),
                new Subject(3,"html5",20),
                  new Subject(2,"js",24),
                new Subject(3,"html5",20),
                  new Subject(2,"js",24),
                new Subject(3,"html5",20),
                  new Subject(2,"js",24),
                new Subject(3,"html5",20),
                   new Subject(1,"html",22),
                new Subject(2,"js",24),
                new Subject(3,"html5",20),
                  new Subject(2,"js",24),
                new Subject(3,"html5",20),
                  new Subject(2,"js",24),
                new Subject(3,"html5",20),
                  new Subject(2,"js",24),
                new Subject(3,"html5",20),
                  new Subject(2,"js",24),
                new Subject(3,"html5",20),
                  new Subject(2,"js",24),
                new Subject(3,"html5",20),   new Subject(1,"html",22),
                new Subject(2,"js",24),
                new Subject(3,"html5",20),
                  new Subject(2,"js",24),
                new Subject(3,"html5",20),
                  new Subject(2,"js",24),
                new Subject(3,"html5",20),
                  new Subject(2,"js",24),
                new Subject(3,"html5",20),
                  new Subject(2,"js",24),
                new Subject(3,"html5",20),
                  new Subject(2,"js",24),
                new Subject(3,"html5",20),
                new Subject(3,"angular",20)
            };
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Console.WriteLine(st);
            watch.Stop();
            Console.WriteLine(watch.Elapsed);
            #endregion
        }
    }
}
