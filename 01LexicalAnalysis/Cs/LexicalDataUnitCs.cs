using System;
using System.Collections.Generic;
using System.Text;
using CodeConvert.SourceDefend.Cs;

namespace CodeConvert._01LexicalAnalysis.Cs
{
    class LexicalDataUnitCs
    {
        private CodeTypeCs code;
        private string token;

        public LexicalDataUnitCs(CodeTypeCs code, string token)
        {
            this.code = code;
            this.token = token;
        }
        public CodeTypeCs Code { get { return code; } }

        public string Token { get { return token; } }

        public override string ToString()
        {

            return "< " + code.ToString()+ " , " + token + " >";
        }
    }
}
