using System;
using System.Collections.Generic;
using System.Text;

namespace CodeConvert._01LexicalAnalysis
{
    class LexicalDataSource
    {
        private string[] line;
        private List<LexicalDataUnit> lexicalDatas = new List<LexicalDataUnit>();
        public string[] Line {get;set;}
        public List<LexicalDataUnit> LexicalDatas { get { return lexicalDatas; } }
    }
}
