using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04Adv_C_
{
    class Question
    {

        public int Id { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }
        //public QAnswer  ;
        public Question(int id, string header, string body)
        {
            Id = id;
            Header = header;
            Body = body;
        }
        public override string ToString()
        {
            return $"ID : {Id}\n{Header}\n{Body}";
        }
    }
}
