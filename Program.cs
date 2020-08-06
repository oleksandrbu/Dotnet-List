using System;
using InternshipTest.Person;
using InternshipTest.Institution;
using InternshipTest.Institution.InterLink;

namespace InternshipTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = {new Student("Andrew Kostenko"), new Student("Julia Veselkina"), new Student("Maria Perechrest")};
            University university = new University("CH.U.I.");
            Internship internship = new Internship("Interlink");
            Knowledge level = new Knowledge(2);
            
            for (int i = 0; i < students.Length; i++){
                students[i].SetKnowledge(new Knowledge(i + 1));
                university.AddStudent(students[i]);
            }

            internship.addSudents(university, level);
            Console.WriteLine("List of internship's students:");
            Console.WriteLine(internship.GetStudents());
        }
    }
}
