using OPP_Exam.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_Exam.exam
{
    internal abstract class Exam
    {
        
        public int Timeofexam { get; set; }
        public int NumofQuestions { get; set; }
        public List<IQuestion> Questions { get; set; }

        public Exam(int Timeofexam, int NumofQuestions)
        {
            this.Timeofexam = Timeofexam;
            this.NumofQuestions = NumofQuestions;
            Questions = new List<IQuestion>();
        }

        public abstract void Show();
    }
}
