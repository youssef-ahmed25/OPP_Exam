using OPP_Exam.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_Exam.exam
{
    internal class Final : Exam
    {
        public Final(int time, int numOfQuestions) : base(time, numOfQuestions)
        {
            Timeofexam = time;
            NumofQuestions = numOfQuestions;
        }
        public override void Show()
        {
            Console.WriteLine($"Final Exam: Time - {Timeofexam} min, Number of Questions - {NumofQuestions}");
            
            foreach (IQuestion q in Questions)
            {
                q.Show();
                if (q is MCQ)
                {
                    Console.Write("your answer:");
                    foreach (var i in q.UserAnswer)
                        Console.Write(i);
                    Console.Write("\nCorrect Answer: ");
                    foreach (var i in q.RightAnswer)
                     Console.Write(q.Answers[i].AnswerText);
                }
                else if (q is TrueorFalse)
                {
                    Console.Write("your answer:");
                    Console.WriteLine(q.UserTorF[0] == 1 ? "True" : "False");

                    Console.Write("Correct Answer:");
                    Console.WriteLine(q.RightAnswer[0] == 1 ? "True" : "False");
                }
            }
        }
    }
}

    

