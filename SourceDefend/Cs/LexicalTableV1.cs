using CodeConvert.Constant;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeConvert.SourceDefend.Cs
{
    partial class LexicalTable
    {

        private Dictionary<string, CodeType> v1 = new Dictionary<string, CodeType>()
        {
           { "=", CodeType.T_Equal},
           { "using", CodeType.T_Equal},
           { ";", CodeType.T_Equal},
           { ".", CodeType.T_Equal}
        };

    }
}
