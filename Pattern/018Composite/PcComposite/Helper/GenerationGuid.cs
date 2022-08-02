using System;
using System.Collections.Generic;
using System.Text;

namespace PcComposite.Helper
{
    static class GenerationGuid
    {

        public static string Get()
        {
            return Guid.NewGuid().ToString().Substring(0, 5);
        }
    }
}
