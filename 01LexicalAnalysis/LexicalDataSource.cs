using System;
using System.Collections.Generic;
using System.Text;

namespace CodeConvert._01LexicalAnalysis
{
    class LexicalDataSource
    {
        private string[] line;
        private List<LexicalDataUnit> lexicalDatas = new List<LexicalDataUnit>();
        public string[] Line { get{ return line; }}
        public List<LexicalDataUnit> LexicalDatas { get { return lexicalDatas; } }

        public override string ToString()
        {
            List<string> l = new List<string>();
            string res = "";
            foreach (LexicalDataUnit lexical in lexicalDatas)
            {
                res += lexical.ToString();
                l.Add(lexical.ToString());
            }
            line = l.ToArray();
            return res;
        }
    }
}
