namespace Structural_Models
{
    public class Student
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public Student(int id, string name, string surname)
        {
            Id = id;
            Name = name;
            Surname = surname;
        }
    }
}
