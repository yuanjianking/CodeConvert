using CodeConvert.Constant;
using CodeConvert.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeConvert._01LexicalAnalysis
{
    abstract class LexicalAnalysis
    {

        public bool IsDigit(in char c)
        {
            return (c >= '0' && c <= '9');
        }

        public bool IsLetter(in char c)
        {
            return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || c == '_';
        }

        abstract public LexicalDataSource Analysis(string[] lines, SourceManager Manager);

    }
}
