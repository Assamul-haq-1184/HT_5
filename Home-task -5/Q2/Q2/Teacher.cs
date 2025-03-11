using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Teacher
    {
        private int Teacher_ID;
        private string Teacher_name;
        private string subject;
        public Teacher(int teacher_ID, string teacher_name, string subject)
        {
            Teacher_ID = teacher_ID;
            Teacher_name = teacher_name;
            this.subject = subject;
        }
        public void Assign_grade(Student student,int Grade)
        {
            student.set_grade(Grade);
        }
        public int get_Teacher_id()
        {
            return Teacher_ID;
        }
        public string get_Nmae()
        {
            return Teacher_name;
        }
        public string get_subject() { return subject; }
    }
}
