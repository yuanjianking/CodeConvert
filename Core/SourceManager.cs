using CodeConvert.Constant;
using CodeConvert.SourceDefend;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeConvert.Core
{
    class SourceManager
    {
        private string version = "";
        private SourceType sourceType = SourceType.Undefine;
        private SouceDefend souceDefend;

        public SourceManager(string version, SourceType type)
        {
            this.version = version;
            this.sourceType = type;        
        }

        public bool Load()
        {
            souceDefend = new SouceDefend(version, sourceType);
            souceDefend.GetIo();
            // 先判断有咩有该语言的定义资源

            // 在判断有没有该语言的转换版本

            // 再判断有没有该语言的输入配置
            return true;
        }
    }
}
