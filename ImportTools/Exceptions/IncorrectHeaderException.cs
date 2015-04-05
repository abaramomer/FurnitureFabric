using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImportTools.Exceptions
{
    public class IncorrectHeaderException : ImportToolException
    {
        public IncorrectHeaderException(IEnumerable<string> headerColumns) : base("")
        {
            StringBuilder message = new StringBuilder("Some column(s) missed or order incorrect, header should be has columns with order: ");

            headerColumns.ToList().ForEach(x => message.Append(string.Format("{0};", x)));

            ImportToolExceptionMessage = message.ToString();
        }
    }
}