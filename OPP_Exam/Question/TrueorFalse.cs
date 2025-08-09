using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_Exam.Question
{
    internal class TrueorFalse: IQuestion
    {

        public string Header_of_question { get; set; }
        public string Body_of_question { get; set; }
        public int Mark { get; set; }
        public Ans[] Answers { get; set; }
        public int[] RightAnswer { get; set; }
        public string[] UserAnswer { get; set; }

        public int[] UserTorF { get; set; } 
        public TrueorFalse(string header_of_question, string body_of_question, int mark, Ans[] answers, int[] rightAnswer, string[] userAnswer, int[] userTorF)
        {
            Header_of_question = header_of_question;
            Body_of_question = body_of_question;
            Mark = mark;
            Answers = answers;
            RightAnswer = rightAnswer;
            UserAnswer = userAnswer;
            UserTorF = userTorF;
        }
        public TrueorFalse(string header_of_question, string body_of_question, int mark, Ans[] answers, int[] rightAnswer)
        {
            Header_of_question = header_of_question;
            Body_of_question = body_of_question;
            Mark = mark;
            Answers = answers;
            RightAnswer = rightAnswer;
            
        }

        public void Show()
        {
            Console.WriteLine($"\nHeader: {Header_of_question}");
            Console.WriteLine($"Body: {Body_of_question}");
            Console.WriteLine($"Mark: {Mark}");
        }
    }
    
        
}

