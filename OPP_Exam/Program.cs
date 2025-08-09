using OPP_Exam.exam;
using OPP_Exam.Question;
using System.Data;

namespace OPP_Exam
{
    internal class Program
    {
        #region function to MCQ quetion from user and save it in class MCQ
        public static MCQ MCQ_Quetion()
        {

            Console.Write("please enter Body: ");
            string questionBody = Console.ReadLine();

            Console.Write("please Enter Mark: ");
            int.TryParse(Console.ReadLine(), out int questionMark);

            Ans[] choices = new Ans[3];
            Console.WriteLine("Choose");

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Please Enter Choose{i + 1}: ");
                string? text = Console.ReadLine();
                choices[i] = new Ans(i + 1, text);
            }

            Console.Write("Please Enter the right answer: ");
            int.TryParse(Console.ReadLine(), out int rightAnswer);
            MCQ mcq = new MCQ("MCQ", questionBody, questionMark, choices, new int[] { rightAnswer });
            return mcq;
        }
        #endregion
        #region function to TrueorFalse quetion from user and save it in class TrueorFalse
        public static TrueorFalse TorF_Quetion()
        {
            Console.Write("please enter Body: ");
            string questionBody = Console.ReadLine();

            Console.Write("please enter Mark: ");
            int.TryParse(Console.ReadLine(), out int questionMark);

            Ans[] choices = new Ans[]
            {
              new Ans(1, "True"),
              new Ans(2, "False")
            };

            Console.Write("Enter the right answer (1 for true | 2 for false): ");
            int.TryParse(Console.ReadLine(), out int rightAnswer);
            TrueorFalse Tf = new TrueorFalse("True or False", questionBody, questionMark, choices, new int[] { rightAnswer });
            return Tf;
        }
        #endregion
        static void Main(string[] args)

        {
            Console.WriteLine("Welcome to the Exam");
            Console.WriteLine("enter subject");
            string subject = Console.ReadLine();
            Console.WriteLine("enter id");
            int.TryParse(Console.ReadLine(), out int id);

            bool x;
            int a;

            do
            {
                Console.WriteLine("enter the type of Exam (1 for Practical 2 for Final): ");
                x = int.TryParse(Console.ReadLine(), out a);
            } while (!x || (a != 1 && a != 2));

            bool y;
            int b;
            do
            {
                Console.WriteLine("enter the Time For Exam (30 min to 180 min): ");
                y = int.TryParse(Console.ReadLine(), out b);
            } while (!y || b < 30 || b > 180);
            int c;
            Console.WriteLine("enter the number of questions ");
            int.TryParse(Console.ReadLine(), out c);


            #region if he take 1 this maen he go practical exam
            if (a == 1)
            {
                Practical practicalExam = new Practical(b, c);
                for (int i = 0; i < c; i++)
                {
                    Console.WriteLine($"\nQuestion {i + 1}:");
                    practicalExam.Questions.Add(MCQ_Quetion());
                }
                #region get answer from user
                //foreach (IQuestion question in practicalExam.Questions) can use var or IQuestion
                foreach (var question in practicalExam.Questions)
                {
                    Console.WriteLine($"Question {question.Body_of_question} ( {question.Mark})");
                    foreach (var choose in question.Answers)
                    {
                        Console.WriteLine($"Choose: {choose.AnswerText}");
                    }
                    Console.WriteLine("enter your answer");
                    string answer = Console.ReadLine();
                    question.UserAnswer = new string[] { answer }; // save answer in in UserAnswer its string array to get all answer of mcq
                }
                #endregion
                practicalExam.Show();
            }
            #endregion

            #region if he take 2 this maen he go final exam
            else if (a == 2)
            {
                Final finalExam = new Final(b, c);
                for (int i = 0; i < c; i++)
                {
                    bool v;
                    int t;

                    do
                    {
                        Console.Write("Enter 1 for MCQ or 2 for True/False: ");
                        v = int.TryParse(Console.ReadLine(), out t);
                    }
                    while (!v || (t != 1 && t != 2));

                    IQuestion question;

                    if (t == 1)// Create question mcq if he take 1 from user if 2 create t/f 
                    {
                        question = MCQ_Quetion();

                        #region print quetion and answer to the user the get anser from user
                        Console.WriteLine($"Question {question.Body_of_question} ({question.Mark})");
                        foreach (var Choose in question.Answers)
                        {
                            Console.WriteLine($"Choose: {Choose.AnswerText}");
                        }
                        Console.Write("Enter your answer: ");
                        string answer = Console.ReadLine();
                        question.UserAnswer = new string[] { answer };
                        #endregion
                    }
                    else
                    {
                        question = TorF_Quetion();
                        //print quetion and answer to the user the get anser from user
                        Console.WriteLine($"Question {question.Body_of_question} ({question.Mark})");
                        Console.Write("Enter your answer (1 for True or 2 for False): ");
                        int.TryParse(Console.ReadLine(), out int answer);
                        question.UserTorF = new int[] { answer };
                    }


                    finalExam.Questions.Add(question);
                }
                Console.WriteLine("-----------------------");
                Subject sub = new Subject(id, subject);
                Console.WriteLine(sub.ToString());
                Console.WriteLine("-----------------------");
                finalExam.Show();
                #endregion
            }
        }
    }
}
