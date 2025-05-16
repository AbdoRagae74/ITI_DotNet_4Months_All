using System.Collections;
using System.Reflection.PortableExecutable;
using System.Text;

namespace Day04Adv_C_
{
    internal class Program
    {


        static void Main(string[] args)
        {
            //string filePath = "E:\\ITI DotNet\\Adv C#\\Day04";
            QuestionList questionList = new QuestionList("List1");
            questionList.Add(new Question(1, "ABC", "AAAHHH"));
            questionList.Add(new Question(2, "sadsad", "AAAHHH"));
            questionList.Add(new Question(3, "sadsad", "AAAHHH"));
            questionList.Add(new Question(3, "sadsad", "AAAHHH"));
            questionList.Add(new Question(3, "sadsad", "AAAHHH"));
            questionList.Add(new Question(3, "sadsad", "AAAHHH"));


            QuestionList questionList2 = new QuestionList("List2");
            questionList2.Add(new Question(1, "ABasdC", "AAAHHH"));
            questionList2.Add(new Question(2, "sa123dsad", "AAAHHH"));
            questionList2.Add(new Question(3, "szzxadsad", "AAAHHH"));
            questionList2.Add(new Question(4, "zzzasadsad", "AAAHHH"));
            questionList2.Add(new Question(5, "5554sadsad", "AAAHHH"));
            questionList2.Add(new Question(6, "23216sadsad", "AAAHHH"));

            Dictionary<Question, List<QAnswer>> CSharpExam = new Dictionary<Question, List<QAnswer>>();
            List<QAnswer> answerList = new List<QAnswer>();
            answerList.Add(new QAnswer(1, "a"));
            answerList.Add(new QAnswer(2, "b"));
            answerList.Add(new QAnswer(3, "c"));
            answerList.Add(new QAnswer(4, "d"));

            CSharpExam.Add(new Question(1, "ABasdC", "AAAHHH"), answerList);
            CSharpExam.Add(new Question(1, "ABasdC", "AAAHHH"),new List<QAnswer>{
      new QAnswer(1,"a"),
      new QAnswer(2,"b"),
      new QAnswer(3,"c"),
      new QAnswer(4,"d")});

            foreach(KeyValuePair<Question,List<QAnswer>> item in CSharpExam)
            {
                Console.WriteLine(item.Key);
                string answers = "";
                foreach(QAnswer answer in item.Value) { answers += answer.ToString(); }
                Console.WriteLine(answers);
            }

        }
    }
}
