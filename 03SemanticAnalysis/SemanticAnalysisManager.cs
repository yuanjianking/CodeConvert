using CodeConvert._02SyntaxParsing;
using CodeConvert.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeConvert._03SemanticAnalysis
{
    class SemanticAnalysisManager
    {
        private SourceManager Manager;
        private SyntaxDataSource dataSource;
        public SemanticAnalysisManager(SourceManager Manager, SyntaxDataSource dataSource)
        {
            this.Manager = Manager;
            this.dataSource = dataSource;
        }

        public SemanticDataSource Analysis()
        {
            SemanticDataSource dataSource = new SemanticDataSource();
            dataSource.Line = this.dataSource.Line;
            return dataSource;
        }
    }
}
