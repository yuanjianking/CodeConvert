using CodeConvert.Constant;
using CodeConvert.Core;
using CodeConvert.SourceDefend;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeConvert._01LexicalAnalysis
{
    [TypeNameAttribute(SourceType.Cs)]
    class LexicalAnalysisCs : LexicalAnalysis
    {
        public override IEnumerable<LexicalDataUnit> Scaner(string[] lines,SourceManager Manager)
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

                        CodeType code = Manager.SourceIn.GetCode(word);
                        if (code != CodeType.T_A_UNDEFEND)
                        {
                            yield return new LexicalDataUnit(code, word);
                        }
                        else
                        {
                            yield return new LexicalDataUnit(CodeType.T_A_IDENTIFIER, word);
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
                        yield return new LexicalDataUnit(CodeType.T_A_CONSTANT, word);
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
                                    if (Manager.SourceIn.GetCode(word + charArray[i] + tmp) == CodeType.T_A_UNDEFEND)
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
                        yield return new LexicalDataUnit(Manager.SourceIn.GetCode(word), word);
                    }
                    else if (c == '@')
                    {     
                        word += charArray[i];
                        i++;
                        yield return new LexicalDataUnit(Manager.SourceIn.GetCode(word), word);
                    }
                    else if (c == '$')
                    {
                        word += charArray[i];
                        i++;
                        yield return new LexicalDataUnit(Manager.SourceIn.GetCode(word), word);
                    }
                    else
                    {
                        CodeType code = CodeType.T_A_UNDEFEND;
                        for ( ; i < len; i++)
                        {
                            if (Manager.SourceIn.HasCode(word + charArray[i], ref code))
                            {
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
                        yield return new LexicalDataUnit(code, word);
                    }                 
                }
            }
        }
    }

}
