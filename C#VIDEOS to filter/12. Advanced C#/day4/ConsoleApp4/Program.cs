using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp4
{
    internal class Program
    {
        class Question
        {
            public int id;
            public string header;
            public string body;
            public Question(int id = 1, string header = "gdskjlj kwerv", string body = "dgfkjgiwp vsklfwpfij wefmwfpmc")
            {
                this.id = id;
                this.header = header;
                this.body = body;
            }

            public override string ToString() 
            {
                return $"Q{id}-header: {header}, body: {body}?";
            }
        }
        class Answer
        {
            public int id;
            public string answer;

            public Answer(int id = 1, string answer = "answer answer answer answer answer answer..")
            {
                this.id = id;
                this.answer = answer;
            }

            public override string ToString() {
                return $"{id} {answer}";
            }
        }
        class QuestionList : List<Question> 
        {
            //counter for instanses
            private static int counter = 0;

            //public QuestionList()
            //{
            //    counter++;
            //}

            public static int ShowCount(QuestionList ql) {
                return counter;
            }

            //creating a file for each QuestionList
            StreamWriter qfile = new StreamWriter($"exam_file_{++counter}.txt");

            public new void Add(Question q)
            {
                base.Add(q);
                //adding question q to "qfile"
                qfile.WriteLine(q);
                //file.Close(); wrong but why?#
                qfile.Flush();
            }
            public override string ToString()
            {
                string txt = "";
                foreach (Question item in this)
                {
                    txt += item.ToString() +"\n";
                }
                return txt;
            }
        }
        static void Main()
        {
            #region Task 1
            //question 1
            Question q1 = new Question(1);
            //answer list for q1
            List<Answer> q1answers = new List<Answer>();
            q1answers.Add(new Answer());
            q1answers.Add(new Answer(2));
            q1answers.Add(new Answer(3));

            //question 2
            Question q2 = new Question(2);
            //answer list for q2
            List<Answer> q2answers = new List<Answer>();
            q2answers.Add(new Answer());
            q2answers.Add(new Answer(2));
            q2answers.Add(new Answer(3));

            //question list for exam 1
            QuestionList exam1questions = new QuestionList();
            exam1questions.Add(q1);
            exam1questions.Add(q2);
                //question 3
            exam1questions.Add(new Question(3));

            //exam 1 dictionary
            Dictionary<Question, List<Answer>> exam1 = new Dictionary<Question, List<Answer>>();

            exam1.Add(q1, q1answers);
            exam1.Add(q2, q2answers);
            exam1.Add(new Question(3), new List<Answer>() {
                //answer list for q3
                new Answer(1),
                new Answer(2),
                new Answer(3)
            });

            //print exam 1
            foreach (KeyValuePair<Question, List<Answer>> dicElement in exam1) //foreach(element of type pair(question and list of answers) in exam 1)
            {
                Console.WriteLine(dicElement.Key);
                foreach (Answer ans in dicElement.Value) //dicElement.Value is the collection to loop over
                {
                    Console.WriteLine(ans);
                }
                Console.WriteLine("-----------------------------");
            }
            #endregion


            //testing filewriter
            QuestionList qlist2 = new QuestionList();

            qlist2.Add(q2);
            qlist2.Add(q1);

            Console.WriteLine(QuestionList.ShowCount(exam1questions));
        }
    }
}
