using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_Exam.Question
{
    internal interface IQuestion
    {
        public string Header_of_question  { get; set; }
        public string Body_of_question { get; set; }
        public int Mark { get; set; }
        public Ans[] Answers { get; set; }
        public int[] RightAnswer { get; set; }
        string[] UserAnswer { get; set; }
        int[] UserTorF { get; set; }
        public void Show();
    }
}
