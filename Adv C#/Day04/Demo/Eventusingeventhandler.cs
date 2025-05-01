namespace part2
{
    //define delegate 
    //  delegate void mydel(Exam ex, examargs e);
    //delegate void eventhandler(object sender ,eventargs e)
    //delegate void eventhandler<t:eventargs>(object sender ,t e)
    //delegate void eventhandler<t:eventargs>(object sender ,examargs e)

    class examargs :EventArgs
    {
        public string location { get; set; }
        public DateTime time { get; set; }
        public examargs(string location, DateTime time)
        {
            this.location = location;
            this.time = time;
        }
    }
    class Exam
    {
        public int num { get; set; }
        public string subjectname { get; set; }
        public int duration { get; set; }
        public Dictionary<string, List<string>> examquestions { get; set; }

        //define ref from delegate
        public event EventHandler<examargs> startexam;
        public Exam(int num, string subjectname, int duration, Dictionary<string, List<string>> examquestions)
        {
            this.num = num;
            this.subjectname = subjectname;
            this.duration = duration;
            this.examquestions = examquestions;
        }
        public void OnStartexam()
        {

            startexam?.Invoke(this, new examargs("lec1", DateTime.Now.AddMinutes(10)));
        }

        public override string ToString()
        {
            string txt = $"num: {num} \t subject: {subjectname} \t Duration: {duration}minutes \n";
            foreach (KeyValuePair<string, List<string>> item in examquestions)
            {
                txt += item.Key + "? \n";
                foreach (string ans in item.Value)
                {
                    txt += ans + "\n";
                }
                txt += "------------------------\n";
            }
            return txt;
        }
    }
    class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public Student(int id = 0, string name = "", int age = 0)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
        public void answerexam(object sender, examargs e)
        {
            Exam ex=sender as Exam;
            Console.WriteLine(ex);
            Console.WriteLine($" student {name} start answer ... @{e.time.ToShortTimeString()},location :{e.location}");

        }
        public override string ToString()
        {
            return $"{id}-{name} \t {age}years old";
        }


    }
    class admin
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public admin(int id = 0, string name = "", int age = 0)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public void montior(object sender, examargs e)
        {
            Exam ex = sender as Exam;
            Console.WriteLine($"{name} start montior on {ex.subjectname} exam ,location:{e.location}");
        }
        public override string ToString()
        {
            return $"{id}-{name} \t {age}years old";
        }


    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
            dic.Add("dhdhdhdh hdhdh hdhdh", new List<string>() { "1-eyeye", "2-dhdhdh", "3-djdjdj" });
            dic.Add("shsgdg hdhdh eiei", new List<string>() { "1-eyeye", "2-dhdhdh", "3-djdjdj" });
            dic.Add("eueuhdh eueue eueue", new List<string>() { "1-eyeye", "2-dhdhdh", "3-djdjdj" });
            dic.Add("etetet eyeyey hdhdh", new List<string>() { "1-eyeye", "2-dhdhdh", "3-djdjdj" });

            Exam ex = new Exam(1, "C#", 90, dic);
            Student s = new Student(1, "mostafa", 16);
            admin d = new admin(2, "ali ahmed", 30);
            ex.startexam += s.answerexam;
            ex.startexam += d.montior;

            ex.OnStartexam();

        }
    }
    class test<t> where t:class ,new()
    {
        t a = new t();
    }
}
