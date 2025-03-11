using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adding students");
            Student std1 = new Student(1200,"Ali");
            Student std2 = new Student(1999, "Arham");
            Teacher T1 = new Teacher(1221,"Waqar","OOP");
            Teacher T2 = new Teacher(1222, "Qadeer", "C#");
            Console.WriteLine("\t\t\t-----SCHOOL DETAIL-----");
            School school = new School("NTU", "FSD", 20);
            school.Addstudent(std1);
            school.Addstudent(std2);
            T1.Assign_grade(std1,90);
            T1.Assign_grade(std2, 50);
            T2.Assign_grade(std1, 60);
            Console.WriteLine("               Display Average of Grades of each student ");
            Console.WriteLine($"{std1.GetName()}  has Average  {std1.Average_grade()}");
            Console.WriteLine($"{std2.GetName()} has Average {std2.Average_grade()}");
            Console.WriteLine($"              Display School Information");
            Console.WriteLine(school.Get_name());
            Console.WriteLine(school.Get_location());

            foreach(Student std in school.Get_student())
            {
                if (std != null)
                {
                    Console.WriteLine(std.GetName());
                    Console.WriteLine(std.Get_student_ID());
                }
            }
            
        }
    }
}
