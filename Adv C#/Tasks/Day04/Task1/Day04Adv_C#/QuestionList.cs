using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04Adv_C_
{
    class QuestionList : List<Question>
    {
        public string Name { get; set; }
        public QuestionList(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            StringBuilder q = new StringBuilder();
            foreach (Question s in this)
            {
                q.Append(s.ToString());
            }
            return q.ToString();

        }
        public new void Add(Question q)
        {

            base.Add(q);
            string filePath = "E:\\ITI DotNet\\Adv C#\\Day04\\Lists\\" + $"{this.Name}.txt";
            using (TextWriter tw = new StreamWriter(filePath, true))
            {
                tw.WriteLine(q.ToString());
            }

        }
    }
}
