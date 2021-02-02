using CodeConvert.Constant;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeConvert.SourceDefend.Cs
{
    partial class LexicalTable
    {
        private string[] version = { "1.0", "2.0" };
        private Dictionary<string, Dictionary<string, CodeType>> codeDictionary = new Dictionary<string, Dictionary<string, CodeType>>();

        public LexicalTable()
        {
            codeDictionary.Add("1.0", v1);
            codeDictionary.Add("2.0", v2);
        }

        public bool CheckVersion(string version)
        {
            return version.Contains(version);
        }

        public Dictionary<string, CodeType> GetCodeDictionary(string version)
        {           
            return codeDictionary.GetValueOrDefault(version);
        }
    }
}
