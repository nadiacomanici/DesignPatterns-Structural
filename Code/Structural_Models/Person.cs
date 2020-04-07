using System;

namespace Structural_Models
{
    [Serializable]
    public class Person
    {

        public string Name { get; set; }

        public string Surname { get; set; }


        public Person()
        {

        }

        public Person(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
    }
}
