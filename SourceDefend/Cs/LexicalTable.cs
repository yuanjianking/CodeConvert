using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeConvert.SourceDefend.Cs
{
    partial class LexicalTable
    {
        private string[] version = { "1.0", "2.0" };
        private Dictionary<string, Dictionary<string, CodeTypeCs>> codeDictionary = new Dictionary<string, Dictionary<string, CodeTypeCs>>();
        private string[] keyword = {
                                "abstract",
                                "as",
                                "base",
                                "bool",
                                "break",
                                "byte",
                                "case",
                                "catch",
                                "char",
                                "checked",
                                "class",
                                "const",
                                "continue",
                                "decimal",
                                "default",
                                "delegate",
                                "do",
                                "double",
                                "else",
                                "enum",
                                "event",
                                "explicit",
                                "extern",
                                "false",
                                "finally",
                                "fixed",
                                "float",
                                "for",
                                "foreach",
                                "goto",
                                "if",
                                "implicit",
                                "in",
                                "int",
                                "interface",
                                "internal",
                                "is",
                                "lock",
                                "long",
                                "namespace",
                                "new",
                                "null",
                                "object",
                                "operator",
                                "out",
                                "override",
                                "params",
                                "private",
                                "protected",
                                "public",
                                "readonly",
                                "ref",
                                "return",
                                "sbyte",
                                "sealed",
                                "short",
                                "sizeof",
                                "stackalloc",
                                "static",
                                "string",
                                "struct",
                                "switch",
                                "this",
                                "throw",
                                "true",
                                "try",
                                "typeof",
                                "uint",
                                "ulong",
                                "unchecked",
                                "unsafe",
                                "ushort",
                                "using",
                                "virtual",
                                "void",
                                "volatile",
                                "while",
                                "add",
                                "alias",
                                "ascending",
                                "async",
                                "await",
                                "by",
                                "descending",
                                "dynamic",
                                "equals",
                                "from",
                                "get",
                                "global",
                                "group",
                                "into",
                                "join",
                                "let",
                                "nameof",
                                "notnull",
                                "on",
                                "orderby",
                                "partial",
                                "remove",
                                "select",
                                "set",
                                "unmanaged",
                                "value",
                                "var",
                                "when",
                                "where",
                                "with",
                                "yield"
                            };
        private string[] pretreatment = {"#if",
                                        "#else",
                                        "#elif",
                                        "#endif",
                                        "#define",
                                        "#undef",
                                        "#warning",
                                        "#error",
                                        "#line",
                                        "#nullable",
                                        "#region",
                                        "#endregion",
                                        "#pragma",
                                        "#pragma warning",
                                        "#pragma checksum"
                                         };
        private string[] specialcharacter = {"@", "$"};
        private string[] operatorcharacter1 = { "?", ":", "=", "&", "*", "+", "-", "/", "%", ">", "<", ".", "[", "]", "(", ")", "{", "}", "^" ,"~", "|", "!", ";", "\\", "," };
        private string[] operatorcharacter2 = { "//", "/*", "*/", "::", "=>", "??", "-=", "+=", "->", "++", "--", "==", "!=", ">=", "<=", ".." , ">>", "<<", "&&", "||" };
        private string[] operatorcharacter3 = { "??=", "///" };
        public LexicalTable()
        {
            codeDictionary.Add("1.0", v1);
            codeDictionary.Add("2.0", v2);
        }

        public bool CheckVersion(in string version)
        {
            return version.Contains(version);
        }

        public Dictionary<string, CodeTypeCs> GetCodeDictionary(in string version)
        {           
            return codeDictionary.GetValueOrDefault(version);
        }

        public bool isOperatorCharacter( string c)
        {
            bool res = false;
            if (operatorcharacter1.Where(m => m.Equals(c)).Count() > 0 ||
                operatorcharacter2.Where(m => m.Equals(c)).Count() > 0 ||
                operatorcharacter3.Where(m => m.Equals(c)).Count() > 0)
            {
                res = true;
            }
            return res;
        }

    }
}
