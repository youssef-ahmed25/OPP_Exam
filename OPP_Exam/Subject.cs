using OPP_Exam.exam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_Exam
{
    internal class Subject
    {
        public int Subject_Id { get; set; }
        public string Subject_Name { get; set; }
        public Exam Exam { get; set; }

        public Subject(int id, string name)
        {
            Subject_Id = id;
            Subject_Name = name;
        }

        public void CreateExam(Exam exam)
        {
            Exam = exam;
        }

        public override string ToString() 
        {
            return $"Subject: {Subject_Name} (ID: {Subject_Id})";
        } 
    }
}
