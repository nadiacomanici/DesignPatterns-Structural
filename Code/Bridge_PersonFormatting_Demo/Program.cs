using System;
using Bridge_PersonFormatting_Demo.FormattedObject;
using Bridge_PersonFormatting_Demo.Formatters;
using Structural_Models;

namespace Bridge_PersonFormatting_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Nadia", "Comanici");
            var student = new Student(123, "Simona", "Lungu");

            // person json formatting
            Console.WriteLine("-------- Person as JSON ---------------");
            var formattedPerson = new PersonFormattedObject(person);
            formattedPerson.Formatter = new JsonFormatter();
            Console.WriteLine(formattedPerson.GetObjectAsFormattedString());
            Console.WriteLine();

            // person xml formatting
            Console.WriteLine("-------- Person as XML ---------------");
            formattedPerson.Formatter = new XmlFormatter();
            Console.WriteLine(formattedPerson.GetObjectAsFormattedString());
            Console.WriteLine();

            // person plain object formatting
            Console.WriteLine("-------- Person as Plain object ---------------");
            formattedPerson.Formatter = new PlainTextFormatter();
            Console.WriteLine(formattedPerson.GetObjectAsFormattedString());
            Console.WriteLine();

            // student json formatting
            Console.WriteLine("-------- Student as JSON ---------------");
            var fomattedStudent = new StudentFormattedObject(student);
            fomattedStudent.Formatter = new JsonFormatter();
            Console.WriteLine(fomattedStudent.GetObjectAsFormattedString());
            Console.WriteLine();

            // student xml formatting
            Console.WriteLine("-------- Student as XML ---------------");
            fomattedStudent.Formatter = new XmlFormatter();
            Console.WriteLine(fomattedStudent.GetObjectAsFormattedString());
            Console.WriteLine();
        }
    }
}
