using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace OPP_Exam.Question
{
    internal class MCQ : IQuestion
    {

        public string Header_of_question { get; set; }
        public string Body_of_question { get ; set; }
        public int Mark { get; set; }

        public Ans[] Answers { get; set; }
        public int[] RightAnswer { get; set; }
        public string[] UserAnswer { get; set; }
        public int[] UserTorF { get; set; }

        public MCQ(string header, string body, int mark, Ans[] answers, int[] rightanswer)
        {
            Header_of_question = header;
            Body_of_question = body;
            Mark = mark;
            Answers = answers;
            RightAnswer = rightanswer;
            
        }
        public MCQ(string header, string body, int mark,Ans []answers, int[] rightanswer , string[]useranswer , int[] userTorF)
        {
            Header_of_question = header;
            Body_of_question = body;
            Mark = mark;
            Answers =  answers ;
            RightAnswer = rightanswer;
            UserAnswer = useranswer;
            UserTorF = userTorF;
        }

        public void Show()
        {
            Console.WriteLine($"\nHeader: {Header_of_question}");
            Console.WriteLine($"Body: {Body_of_question}");
            Console.WriteLine($"Mark: {Mark}");
        }   
    }
}
