using CodeConvert.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeConvert._01LexicalAnalysis
{
    class LexicalAnalysisManager
    {
        private SourceManager Manager;
        private string[] line;
        public LexicalAnalysisManager(SourceManager Manager, string[] line)
        {
            this.Manager = Manager;
            this.line = line;
        }

        public LexicalDataSource Analysis() 
        {
            LexicalDataSource dataSource = new LexicalDataSource();
            return dataSource;
        }
    }
}
