using System.Collections.Generic;
using InternshipTest.Person;

namespace InternshipTest.Institution.InterLink
{
    public class Internship
    {
        string name;
        LinkedList<Student> studentList;

        public Internship(string name)
        {
            this.name = name;
        }

        public string GetStudents()
        {
            string str = "";

            foreach (Student student in this.studentList){
                str += $"{student.GetName()}\n";
            }

            return str;
        }

        public void addSudents(University name, Knowledge level){
            this.studentList = name.GetGroup(level);
        }
    }
}
