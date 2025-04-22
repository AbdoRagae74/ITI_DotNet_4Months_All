using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04Adv_C_
{
    class QAnswer
    {

        public int Id { get; set; }
        public string Answer { get; set; }
        public QAnswer(int id, string ans)
        {
            Id = id;
            Answer = ans;
        }
        public override string ToString()
        {
            return $"ID : {Id} : {Answer}\n";
        }
    }
}
