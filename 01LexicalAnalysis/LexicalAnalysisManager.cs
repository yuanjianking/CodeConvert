using CodeConvert.Constant;
using CodeConvert.Core;
using CodeConvert.SourceDefend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CodeConvert._01LexicalAnalysis
{
    class LexicalAnalysisManager
    {
        private Global global = Global.CreateInstance();
        private SourceManager Manager;
        private string[] lines;
        public LexicalAnalysisManager(SourceManager Manager, string[] lines)
        {
            this.Manager = Manager;
            this.lines = lines;
        }

        public LexicalDataSource Analysis() 
        {
            LexicalDataSource dataSource = new LexicalDataSource();
            LexicalAnalysis lexicalAnalysis = Polymorphic.CreateInstance<LexicalAnalysis>(t => t.FullName.Contains("CodeConvert._01LexicalAnalysis") && t.Name.Contains(global.InputType.ToString()), global.InputType);
            dataSource = lexicalAnalysis.Analysis(lines, Manager);
            Console.WriteLine(dataSource.ToString());
            return dataSource;
        }
    }
}
