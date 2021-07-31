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
        private Global global = Global.CreateInstance();
        private LexicalDataSource dataSource;
        public SyntaxParsingManager(SourceManager Manager, LexicalDataSource dataSource)
        {
            this.Manager = Manager;
            this.dataSource = dataSource;
        }

        public SyntaxDataSource Parsing()
        {
            SyntaxDataSource dataSource = new SyntaxDataSource();
            SyntaxParsing  syntaxParsing = Polymorphic.CreateInstance<SyntaxParsing>(t => t.FullName.Contains("CodeConvert._02SyntaxParsing") && t.Name.Contains(global.InputType.ToString()), global.InputType);
            dataSource = syntaxParsing.Parsing(this.dataSource, Manager);
            Console.WriteLine(dataSource.ToString());
            return dataSource;

        }
    }
}
