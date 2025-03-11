using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Student
    {
        private int Student_ID;
        private string Name;
        private int[] Grades;
        private int Grade_count;
     public Student(int ID , string name)
        {
            Student_ID = ID;
            Name = name;
            Grades = new int[5];
            Grade_count = 0;
        }
        public void set_grade(int grade)
        {
            Grades[Grade_count] = grade;
            Grade_count++;
        }
        public double Average_grade()
        {
            if (Grade_count == 0) return 0;
            double sum = 0;
            for (int i = 0; i < Grade_count; i++)
            {
                sum += Grades[i];
                
            }
            return sum/Grade_count;
        }
        public int Get_student_ID()
        {
            return Student_ID;
        }
        public string GetName()
        {
            return Name;
        }
    }
}
