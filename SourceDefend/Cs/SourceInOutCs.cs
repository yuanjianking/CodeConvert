using CodeConvert.Constant;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeConvert.SourceDefend.Cs
{
    [TypeNameAttribute(SourceType.Cs)]
    class SourceInOutCs : ASourceInOut
    {

        LexicalTable lexicalTable = new LexicalTable();

        protected override bool CheckVersion()
        {
            return lexicalTable.CheckVersion(Version);
        }


        protected override void LoadDefend()
        {
           // throw new NotImplementedException();
        }

        public override CodeType GetCode(in string str)
        {
            CodeType code = CodeType.T_UnDefend;
            lexicalTable.GetCodeDictionary(Version).TryGetValue(str, out code);
            return code;
        }
    }
}
