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
                        while ((i < len) && (IsLetter(charArray[i]) || IsDigit(charArray[i])))
                        {
                            word += charArray[i];
                            i++;
                        }

                        CodeType code = Manager.SourceIn.GetCode(word);
                        if (code != CodeType.T_UnDefend)
                        {
                            yield return new LexicalDataUnit(code, word);
                        }
                        else
                        {
                            yield return new LexicalDataUnit(CodeType.T_Identifier, word);
                        }
                    }
                    else if (IsDigit(c))
                    {
                        while ((i < len) && IsDigit(charArray[i]))
                        {
                            word += charArray[i];
                            i++;
                        }
                        yield return new LexicalDataUnit(CodeType.T_Constant, word);
                    }
                    else if (c == '#')
                    {
                        word += charArray[i];
                        i++;
                        while ((i < len) && IsLetter(charArray[i]))
                        {
                            word += charArray[i];
                            i++;
                        }

                        if (word.Equals("#pragma") && (i < len) && charArray[i] == ' ' && (charArray[i + 1] == 'w' || charArray[i + 1] == 'c'))
                        {
                            word += charArray[i];
                            i ++;
                            while ((i < len) && IsLetter(charArray[i]))
                            {
                                word += charArray[i];
                                i++;
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
                        CodeType code = CodeType.T_UnDefend;
                        for (; i < len; i++)
                        {
                            if (Manager.SourceIn.HasCode(word + charArray[i], ref code))
                            {
                                word += charArray[i];
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
