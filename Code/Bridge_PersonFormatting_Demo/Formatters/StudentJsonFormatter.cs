using Newtonsoft.Json;
using Structural_Models;

namespace Bridge_PersonFormatting_Demo.Formatters
{
    public class StudentJsonFormatter
    {
        public string GetFormattedObject(Student student)
        {
            return JsonConvert.SerializeObject(student);
        }
    }
}
