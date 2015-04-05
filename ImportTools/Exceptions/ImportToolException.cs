using System;

namespace ImportTools.Exceptions
{
    public class ImportToolException : Exception
    {
        public string ImportToolExceptionMessage { get; set; }

        public ImportToolException(string message) : base(message)
        {
            ImportToolExceptionMessage = message;
        }
    }
}