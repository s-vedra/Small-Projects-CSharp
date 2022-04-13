using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Questions
    {
        public string Question { get; set; }
        public List<string> Options { get; set; }
        public int Answers { get; set; }


        public Questions(string question, List<string> options, int answer)
        {
            Question = question;
            Options = options;
            Answers = answer;
        }
    }
}
