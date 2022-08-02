using System;
using System.Collections.Generic;
using System.Text;

namespace PcComposite.Exceptions
{
    class NotTopLevelComponentException : Exception
    {
        public NotTopLevelComponentException() 
            : base("Не является компонентом верхнего уровня. Не может быть разложен на более мелкие детали")
        {

        }
    }
}
