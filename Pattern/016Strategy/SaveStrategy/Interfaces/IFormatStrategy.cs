using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveStrategy.interfaces
{
    interface IFormatStrategy
    {
        void Init(StringBuilder sb);
        void AddElement(StringBuilder sb, string title, string value);
        void Close(StringBuilder sb);
    }

}
