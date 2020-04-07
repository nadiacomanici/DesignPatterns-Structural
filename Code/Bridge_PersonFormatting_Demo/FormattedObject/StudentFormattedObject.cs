using Bridge_PersonFormatting_Demo.Formatters;
using Structural_Models;

namespace Bridge_PersonFormatting_Demo.FormattedObject
{
    public class StudentFormattedObject : IFormattedObject
    {
        private Student _student;

        public StudentFormattedObject(Student student)
        {
            _student = student;
        }

        public IFormatter Formatter { get; set; }

        public string GetObjectAsFormattedString()
        {
            return Formatter.GetFormattedObject(_student);
        }
    }
}
