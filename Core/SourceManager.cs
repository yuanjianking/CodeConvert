using CodeConvert.Constant;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeConvert.Core
{
    class SourceManager
    {
        private string v = "";
        private SourceType type = SourceType.Undefine;

        public SourceManager(string version, SourceType type)
        {
            this.v = version;
            this.type = type;        
        }

        public void LoadIn()
        { 
            // 先判断有咩有该语言的定义资源

            // 在判断有没有该语言的转换版本

            // 再判断有没有该语言的输入配置
        
        }


        public void LoadOut()
        {
            // 先判断有咩有该语言的定义资源

            // 在判断有没有该语言的转换版本

            // 再判断有没有该语言的输出配置

        }
    }
}
