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
            CodeType ct = CodeType.T_UnDefend;
            LexicalAnalysis lexicalAnalysis = Polymorphic.CreateInstance<LexicalAnalysis>(t => t.FullName.Equals("CodeConvert._01LexicalAnalysis") && t.Name.Contains(global.InputType.ToString()), global.InputType);

            IEnumerator<LexicalDataUnit> lexicalDatas = lexicalAnalysis.Scaner(lines, Manager).GetEnumerator();
            do
            {
                if (lexicalDatas.MoveNext())
                {
                    LexicalDataUnit res = lexicalDatas.Current;
                    ct = res.Code;
                    switch (ct)
                    {
                        case CodeType.T_UnDefend:
                            break;
                        case CodeType.T_Identifier:
                        case CodeType.T_Constant:
                        default:
                            dataSource.LexicalDatas.Add(new LexicalDataUnit(res.Code, res.Token));
                            break;
                    }
                }
                else
                {
                    break;
                }
            }
            while (ct != CodeType.T_UnDefend);
            Console.WriteLine(dataSource.LexicalDatas.ToString());
            return dataSource;
        }

      



    }
}
