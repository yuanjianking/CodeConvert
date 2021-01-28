using System;
using System.Collections.Generic;
using System.Text;

namespace CodeConvert.Constant
{
    class FileExtension
    {
        private string [] ext = { ".c", ".cpp", ".cs", ".java", ".js" };

        public string this [SourceType key]
        {
            set { /*value;*/ }
            get { return ext[(int)key]; }
        }

    }
}
