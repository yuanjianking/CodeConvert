using CodeConvert._01LexicalAnalysis;
using CodeConvert._02SyntaxParsing;
using CodeConvert._03SemanticAnalysis;
using CodeConvert._04IntermediateCodeGeneration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CodeConvert.Core
{
    class Convert
    {
        public static void Run()
        {
            // 取得全局参数
            Global global = Global.CreateInstance();

            // 加载输入语法规则
            SourceManager inManager = new SourceManager(global.InputVersion, global.InputType);
            if (!inManager.Load()) return;
          
            // 加载输出语法规则
            SourceManager outManager = new SourceManager(global.OutputVersion, global.OutputType);
            if (!inManager.Load()) return;

            // 创建输出文件夹
            FileWriter writer = new FileWriter();
            writer.CreateDirectory(global.DestinationPath);

            // 读取源文件     
            FileReader reader = new FileReader();
            foreach (FileInfo info in reader.WalkDirectoryTree(global.SourcePath))
            {
                if (info is null)
                {
                    return;
                }
                else {
                    string [] line = reader.ReadAllLines(info.FullName);
                    // 创建符号表
                    // 词法分析
                    LexicalAnalysisManager lexicalAnalysis = new LexicalAnalysisManager(inManager, line);
                    LexicalDataSource lexicalDataSource = lexicalAnalysis.Analysis();

                    // 语法分析
                    SyntaxParsingManager syntaxParsing = new SyntaxParsingManager(inManager, lexicalDataSource);
                    SyntaxDataSource syntaxDataSource = syntaxParsing.Analysis();

                    // 语义分析
                    SemanticAnalysisManager semanticAnalysis = new SemanticAnalysisManager(inManager, syntaxDataSource);
                    SemanticDataSource semanticDataSource = semanticAnalysis.Analysis();

                    // 转换目标代码
                    IntermediateCodeGenerationManager intermediateCodeGeneration = new IntermediateCodeGenerationManager(inManager, semanticDataSource);
                    string[] source = intermediateCodeGeneration.Generation();
                    // 生成代码文件                  
                    writer.WriteAllLines(source, global.DestinationPath + info.Name /*ext*/);

                }
            }
        }
    }
}
