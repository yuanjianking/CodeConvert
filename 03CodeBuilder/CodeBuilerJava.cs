using CodeConvert._02SyntaxParsing;
using CodeConvert._02SyntaxParsing.Struct;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeConvert._03CodeBuilder
{
    class CodeBuilerJava
    {
        SyntaxDataSource syntaxData;
      
        public CodeBuilerJava(SyntaxDataSource syntaxData)
        {
            this.syntaxData = syntaxData;
        }

        public string[] Build()
        {
            int i = 0;
            string[] lines = new string[1024];

            lines[i++] = "package " + syntaxData.File.c.n + ";";

            foreach(String u in syntaxData.File.u)
             {
                lines[i++] = "import " + u + ";";
            }

            ClassStruct c =  syntaxData.File.c.c;
            StringBuilder sb = new StringBuilder();
            if (c.isabstract)
            {
                sb.Append("Abstract ");
            }
            if (c.isStatic)
            {
                sb.Append("static ");
            }


            sb.Append(c.scop + " " + c.name);
            lines[i++] = sb.ToString();

            {
                lines[i++] = "{";
                lines[i++] = "//body";
                lines[i++] = "}";
            }

            return lines;
        }
    }
}
