using CodeConvert.Constant;
using CodeConvert.Core;
using CodeConvert.SourceDefend;
using CodeConvert.SourceDefend.Cs;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeConvert._01LexicalAnalysis.Cs
{
    [TypeNameAttribute(SourceType.Cs)]
    class LexicalAnalysisCs : LexicalAnalysis
    {

        public override LexicalDataSource Analysis(string[] lines, SourceManager Manager)
        {
            return AnalysisCs(lines, Manager);
        }

        private LexicalDataSourceCs AnalysisCs(string[] lines, SourceManager Manager)
        {
            LexicalDataSourceCs dataSource = new LexicalDataSourceCs();
            CodeTypeCs ct = CodeTypeCs.T_A_UNDEFEND;
            IEnumerator<LexicalDataUnitCs> lexicalDatas = Scaner(lines, Manager).GetEnumerator();
            do
            {
                if (lexicalDatas.MoveNext())
                {
                    LexicalDataUnitCs res = lexicalDatas.Current;
                    ct = res.Code;
                    switch (ct)
                    {
                        case CodeTypeCs.T_A_UNDEFEND:
                            break;
                        case CodeTypeCs.T_A_IDENTIFIER:
                        case CodeTypeCs.T_A_CONSTANT:
                        default:
                            dataSource.LexicalDatas.Add(new LexicalDataUnitCs(res.Code, res.Token));
                            break;
                    }
                }
                else
                {
                    break;
                }
            }
            while (ct != CodeTypeCs.T_A_UNDEFEND);
            return dataSource;
        }


        private IEnumerable<LexicalDataUnitCs> Scaner(string[] lines,SourceManager Manager)
        {
            foreach (string line in lines)
            {
                char[] charArray = line.ToCharArray();
                int i = 0;
                int len = charArray.Length;
                while (i < len)
                {
                    char c = charArray[i];
                    string word = "";
                    if (c.ToString().Trim().Length == 0)
                    {
                        i++;
                    }
                    else if (IsLetter(c))
                    {
                        for (; i < len; i++)
                        {
                            if (IsLetter(charArray[i]) || IsDigit(charArray[i]))
                            {
                                word += charArray[i];
                                continue;
                            }
                            else 
                            {
                                break;
                            }
                        }

                        CodeTypeCs code = Manager.SourceIn.GetCode<CodeTypeCs>(word);
                        if (code != CodeTypeCs.T_A_UNDEFEND)
                        {
                            yield return new LexicalDataUnitCs(code, word);
                        }
                        else
                        {
                            yield return new LexicalDataUnitCs(CodeTypeCs.T_A_IDENTIFIER, word);
                        }
                    }
                    else if (IsDigit(c))
                    {
                        for (; i < len; i++)
                        {
                            if (IsDigit(charArray[i]))
                            {
                                word += charArray[i];
                                continue;
                            }
                            else
                            {
                                break;
                            }
                        }
                        yield return new LexicalDataUnitCs(CodeTypeCs.T_A_CONSTANT, word);
                    }
                    else if (c == '#')
                    {
                        for (word += charArray[i++]; i < len; i++)
                        {
                            if (IsLetter(charArray[i]))
                            {
                                word += charArray[i];
                                continue;
                            }
                            else if (charArray[i] == ' ')
                            {
                                if (word.Equals("#pragma"))
                                {
                                    string tmp = "";
                                    int j = i + 1;
                                    for ( ; j < len; j++)
                                    {
                                        if (IsLetter(charArray[i]))
                                        {
                                            tmp += charArray[i];
                                            continue;
                                        }
                                        else 
                                        {
                                            break;
                                        }
                                    }
                                    if (Manager.SourceIn.GetCode<CodeTypeCs>(word + charArray[i] + tmp) == CodeTypeCs.T_A_UNDEFEND)
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        word = word + charArray[i] + tmp;
                                        i = j;
                                        break;
                                    };
                                }
                                else
                                {
                                    break;
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                        yield return new LexicalDataUnitCs(Manager.SourceIn.GetCode<CodeTypeCs>(word), word);
                    }
                    else if (c == '@')
                    {     
                        word += charArray[i];
                        i++;
                        yield return new LexicalDataUnitCs(Manager.SourceIn.GetCode<CodeTypeCs>(word), word);
                    }
                    else if (c == '$')
                    {
                        word += charArray[i];
                        i++;
                        yield return new LexicalDataUnitCs(Manager.SourceIn.GetCode<CodeTypeCs>(word), word);
                    }
                    else
                    {
                        CodeTypeCs code = CodeTypeCs.T_A_UNDEFEND;
                        for ( ; i < len; i++)
                        {
                            CodeTypeCs codeType = CodeTypeCs.T_A_UNDEFEND;
                            if (Manager.SourceIn.HasCode <CodeTypeCs> (word + charArray[i], ref codeType))
                            {
                                code = codeType;
                                word += charArray[i];
                                continue;
                            }
                            else
                            {
                                break;
                            }
                        }
                        if (string.IsNullOrEmpty(word))
                        {
                            word += charArray[i];
                            i++;
                        }
                        yield return new LexicalDataUnitCs(code, word);
                    }                 
                }
            }
        }
    }

}
