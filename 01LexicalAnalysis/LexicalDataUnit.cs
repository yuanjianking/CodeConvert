using CodeConvert.Constant;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeConvert._01LexicalAnalysis
{
    class LexicalDataUnit
    {
        private CodeType code;
        private string token;

        public LexicalDataUnit(CodeType code, string token)
        {
            this.code = code;
            this.token = token;
        }
        public CodeType Code { get { return code; } }

        public string Token { get { return token; } }

        public override string ToString()
        {

            return "< " + code.ToString()+ " , " + token + " >";
        }
    }
}
