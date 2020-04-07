using Bridge_PersonFormatting_Demo.Formatters;

namespace Bridge_PersonFormatting_Demo.FormattedObject
{
    public interface IFormattedObject
    {
        IFormatter Formatter { get; set; }

        string GetObjectAsFormattedString();
    }
}
