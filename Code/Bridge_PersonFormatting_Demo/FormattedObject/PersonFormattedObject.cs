using Bridge_PersonFormatting_Demo.Formatters;
using Structural_Models;

namespace Bridge_PersonFormatting_Demo.FormattedObject
{
    public class PersonFormattedObject : IFormattedObject
    {
        private Person _person;

        public PersonFormattedObject(Person person)
        {
            _person = person;
        }

        public IFormatter Formatter { get; set; }

        public string GetObjectAsFormattedString()
        {
            return Formatter.GetFormattedObject(_person);
        }
    }
}
