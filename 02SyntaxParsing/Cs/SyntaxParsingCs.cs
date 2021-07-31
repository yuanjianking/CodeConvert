using CodeConvert._01LexicalAnalysis;
using CodeConvert._01LexicalAnalysis.Cs;
using CodeConvert._02SyntaxParsing.Struct;
using CodeConvert.Constant;
using CodeConvert.Core;
using CodeConvert.SourceDefend;
using CodeConvert.SourceDefend.Cs;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeConvert._02SyntaxParsing.Cs
{
    [TypeNameAttribute(SourceType.Cs)]
    class SyntaxParsingCs : SyntaxParsing
    {
        public override SyntaxDataSource Parsing(LexicalDataSource dataSource, SourceManager Manager)
        {
            return ParsingCs((LexicalDataSourceCs)dataSource, Manager);
        }

        private SyntaxDataSourceCs ParsingCs(LexicalDataSourceCs dataSource, SourceManager Manager)
        {
            SyntaxDataSourceCs syntaxDataSourceCs = new SyntaxDataSourceCs();
            FileStruct fileStruct;
            fileStruct.u = new List<string>();
            fileStruct.c = new CodeStruct();
            fileStruct.c.c = new ClassStruct();
            fileStruct.c.c.scop = "public";
            for (int i = 0; i < dataSource.LexicalDatas.Count; i++)
            {
                LexicalDataUnitCs unitCs = dataSource.LexicalDatas[i];

                if (unitCs.Token.Equals("using"))
                {
                    StringBuilder u = new StringBuilder();
                    for (int j = i + 1; j < dataSource.LexicalDatas.Count; j++)
                    {
                        LexicalDataUnitCs unitCsTemp = dataSource.LexicalDatas[j];
                        if (unitCsTemp.Token.Equals(";"))
                        {
                            fileStruct.u.Add(u.ToString());
                            i = j;
                            break;
                        }
                        else
                        {
                            u.Append(unitCsTemp.Token);
                        }
                    }
                }
                else if (unitCs.Token.Equals("namespace"))
                {
                    StringBuilder u = new StringBuilder();
                    for (int j = i + 1; j < dataSource.LexicalDatas.Count; j++)
                    {
                        LexicalDataUnitCs unitCsTemp = dataSource.LexicalDatas[j];
                        if (unitCsTemp.Token.Equals("{"))
                        {
                            fileStruct.c.n = u.ToString();
                            i = j;
                            break;
                        }
                        else
                        {
                            u.Append(unitCsTemp.Token);
                        }
                    }
                }
                else if (unitCs.Token.Equals("class"))
                {
                    StringBuilder u = new StringBuilder();
                    for (int j = i + 1; j < dataSource.LexicalDatas.Count; j++)
                    {
                        LexicalDataUnitCs unitCsTemp = dataSource.LexicalDatas[j];
                        if (unitCsTemp.Token.Equals("public"))
                        {
                            fileStruct.c.c.scop = "public";
                        }
                        else if (unitCsTemp.Token.Equals("protected"))
                        {
                            fileStruct.c.c.scop = "protected";
                        }
                        else if (unitCsTemp.Token.Equals("private"))
                        {
                            fileStruct.c.c.scop = "private";
                        }
                        else if (unitCsTemp.Token.Equals("abstract"))
                        {
                            fileStruct.c.c.isabstract = true;
                        }
                        else if (unitCsTemp.Token.Equals("static"))
                        {
                            fileStruct.c.c.isStatic = true;
                        }
                        else if (unitCsTemp.Token.Equals("{"))
                        {
                            fileStruct.c.c.name = u.ToString();
                            i = j;
                            break;
                        }
                        else if (unitCsTemp.Token.Equals(":"))
                        {
                            fileStruct.c.c.name = u.ToString();
                            i = j;
                            string u1 = "";
                            for (int k = j + 1; k < dataSource.LexicalDatas.Count; j++)
                            {
                                LexicalDataUnitCs unitCsTemp1 = dataSource.LexicalDatas[k];
                                if (unitCsTemp1.Token.Equals("{"))
                                {
                                    j = k;
                                    break;
                                }
                                else if (unitCsTemp1.Token.Equals(","))
                                {

                                }
                                else
                                {
                                    u1 = unitCsTemp.Token;
                                }

                            }
                            break;
                        }
                        else
                        {
                            u.Append(unitCsTemp.Token);
                        }
                    }
                }
                else if (unitCs.Token.Equals("}"))
                {
                    continue;
                }
                else { 
                    //LL(1)
                }
            }
            syntaxDataSourceCs.File = fileStruct;
            return syntaxDataSourceCs;
        }
    }
}
