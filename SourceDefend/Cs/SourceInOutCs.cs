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

        public override T GetCode<T>(in string word)
        {
            CodeTypeCs code = CodeTypeCs.T_A_UNDEFEND;
            lexicalTable.GetCodeDictionary(Version).TryGetValue(word, out code);
            return (T)Convert.ChangeType(code, typeof(T));
        }

        public override bool HasCode<T>(in string word, ref T code)
        {
            bool res = false;
            CodeTypeCs codeType = CodeTypeCs.T_A_UNDEFEND;
            if (res = lexicalTable.isOperatorCharacter(word))
            {
                res = lexicalTable.GetCodeDictionary(Version).TryGetValue(word, out codeType);
            }
            code = (T)Convert.ChangeType(codeType, typeof(T));
            return res;
        }
    }
}
