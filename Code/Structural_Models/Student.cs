using System;

namespace Structural_Models
{
    [Serializable]
    public class Student : Person
    {
        public int Id { get; set; }

        public Student()
        {

        }

        public Student(int id, string name, string surname) : base(name, surname)
        {
            Id = id;
        }
    }
}
