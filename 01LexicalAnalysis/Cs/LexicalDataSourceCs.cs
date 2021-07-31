using System;
using System.Collections.Generic;
using System.Text;

namespace CodeConvert._01LexicalAnalysis.Cs
{
    class LexicalDataSourceCs : LexicalDataSource
    {     
        private List<LexicalDataUnitCs> lexicalDatas = new List<LexicalDataUnitCs>();
      
        public List<LexicalDataUnitCs> LexicalDatas { get { return lexicalDatas; } }

        public override string ToString()
        {
            List<string> l = new List<string>();
            string res = "";
            foreach (LexicalDataUnitCs lexical in lexicalDatas)
            {
                res += lexical.ToString();
                l.Add(lexical.ToString());
            }
            line = l.ToArray();
            return res;
        }
    }
}
