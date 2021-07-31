using CodeConvert._01LexicalAnalysis;
using CodeConvert.Constant;
using CodeConvert.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeConvert._02SyntaxParsing
{
    abstract class SyntaxParsing
    {
        abstract public SyntaxDataSource Parsing(LexicalDataSource dataSource, SourceManager Manager);
    }
}
