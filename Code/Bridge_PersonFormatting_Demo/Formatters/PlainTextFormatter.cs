using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_PersonFormatting_Demo.Formatters
{
    class PlainTextFormatter : IFormatter
    {
        public string GetFormattedObject(object obj)
        {
            return "todo";
        }
    }
}
