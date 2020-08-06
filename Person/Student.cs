namespace InternshipTest.Person
{
    public class Student
    {
        string name;
        Knowledge level;

        public Student(string name)
        {
            this.name = name;
        }

        public void SetKnowledge(Knowledge level)
        {
            this.level = level;
        }

        public Knowledge GetKnowledge(){
            return this.level;
        }

        public string GetName(){
            return this.name;
        }
    }
}