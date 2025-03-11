using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class School
    {
        private string School_name;

        private string Location;
        private Student[] students;
        private int student_count;

        public School(string school_name, string location,int No_of_student)
        {
            School_name = school_name;
            Location = location;

            students = new Student[No_of_student];
        }
        public void Addstudent(Student student)
        {
            students[student_count] = student;
            student_count++;
        }
        public string Get_name() { return School_name; }
        public string Get_location() { return Location; }
        public Student[] Get_student() { return students; }
    }
}
