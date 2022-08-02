using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageInterpreterLibrary.Exceptions
{
    public class InterpreterException : Exception
    {
        public int ErrorPosition { get; init; }
        public string Text { get; init; }
    }
}
