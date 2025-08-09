using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_Exam
{
    internal class Ans
    {
        public int AnswerId;
        public string AnswerText;

        public Ans(int answerId, string answerText)
        {
            AnswerId = answerId;
            AnswerText = answerText;
        }
        //public override string ToString()
        //{
        //    return $"Answer ID: {AnswerId}, Answer Text: {AnswerText}";
        //}
    }
}
