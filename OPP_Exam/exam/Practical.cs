using OPP_Exam.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_Exam.exam
{
    internal class Practical : Exam
    {
        public Practical(int time, int numOfQuestions) : base(time, numOfQuestions) 
        {
            Timeofexam = time;
            NumofQuestions = numOfQuestions;
        }

        public override void Show()
        {
            Console.WriteLine($"Practical Exam: Time - {Timeofexam} min, Number of Questions - {NumofQuestions}");
            //foreach (var q in Questions) can use var or IQuestion
            foreach (IQuestion q in Questions)
            {
                q.Show();
                Console.Write("Your answer: ");
                foreach (var i in q.UserAnswer)
                    Console.Write(i); 

                Console.Write("\nCorrect Answer: ");
                foreach (var i in q.RightAnswer)
                    Console.Write(q.Answers[i].AnswerText);

            }
            
        }
    }
}
