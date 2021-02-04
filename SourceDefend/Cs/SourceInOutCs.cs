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

        public override CodeType GetCode(in string word)
        {
            CodeType code = CodeType.T_UnDefend;
            lexicalTable.GetCodeDictionary(Version).TryGetValue(word, out code);
            return code;
        }

        public override bool HasCode(in string word, ref CodeType code)
        {
            bool res = false;
            if(lexicalTable.isOperatorCharacter(word))
            {
                res = lexicalTable.GetCodeDictionary(Version).TryGetValue(word, out code);
            }
            return res;
        }
    }
}
