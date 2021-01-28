using CodeConvert._01LexicalAnalysis;
using CodeConvert.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeConvert._02SyntaxParsing
{
    class SyntaxParsingManager
    {
        private SourceManager Manager;
        private LexicalDataSource dataSource;
        public SyntaxParsingManager(SourceManager Manager, LexicalDataSource dataSource)
        {
            this.Manager = Manager;
            this.dataSource = dataSource;
        }

        public SyntaxDataSource Analysis()
        {
            SyntaxDataSource dataSource = new SyntaxDataSource();
            dataSource.Line = this.dataSource.Line;
            return dataSource;
        }
    }
}
