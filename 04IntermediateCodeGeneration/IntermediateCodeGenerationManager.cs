using CodeConvert._03SemanticAnalysis;
using CodeConvert.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeConvert._04IntermediateCodeGeneration
{
    class IntermediateCodeGenerationManager
    {
        private SourceManager Manager;
        private SemanticDataSource dataSource;
        public IntermediateCodeGenerationManager(SourceManager Manager, SemanticDataSource dataSource)
        {
            this.Manager = Manager;
            this.dataSource = dataSource;
        }

        public string [] Generation()
        {
            string[] text = null;
            return text;
        }
    }
}
