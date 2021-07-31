using System;
using System.Collections.Generic;
using System.Text;

namespace CodeConvert._02SyntaxParsing.Struct
{
    struct FunctionStruct
    {
        public String Type;
        public String name;
        public String scop;
        public Boolean isStatic;
        public Boolean isabstract;
        public String r;
        public List<ParameterStruct> p;
        public FunctionBodyStruct b;
    }
}
