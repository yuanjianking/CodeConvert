using System;
using System.Collections.Generic;
using System.Text;

namespace CodeConvert._02SyntaxParsing.Struct
{
    struct ClassStruct
    {
       
        public String name;
        public String scop;
        public Boolean isStatic;
        public Boolean isabstract;

        public List<FunctionStruct> f;
        public List<VariableStruct> v;
    }
}
