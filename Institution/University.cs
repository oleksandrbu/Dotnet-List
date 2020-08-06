using InternshipTest.Person;
using System.Collections.Generic;

namespace InternshipTest.Institution
{
    public class University
    {
        string name;
        LinkedList<Student> studentList;

        public University(string name)
        {
            this.name = name;
            this.studentList = new LinkedList<Student>();
        }

        public void AddStudent(Student student)
        {
            studentList.AddLast(student);
        }

        public LinkedList<Student> GetGroup(Knowledge level){
            LinkedList<Student> studentGroup = new LinkedList<Student>();

            foreach (Student student in studentList)
            {
                if (student.GetKnowledge().GetValue() >= level.GetValue()) studentGroup.AddLast(student);
            }

            return studentGroup;
        }
    }
}
