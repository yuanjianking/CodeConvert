using System;
using System.Collections.Generic;
using System.Text;

namespace CodeConvert.Constant
{
    class FileExtension
    {
        private string [] ext = { ".c", ".cpp", ".cs", ".java", ".js" };
        private static FileExtension me = null;
        private FileExtension() { }

        public string this [SourceType key]
        {
            set { /*value;*/ }
            get { return ext[(int)key]; }
        }
      

        public static FileExtension Get()
        {
            if (me == null)
            {
                me = new FileExtension();
            }
            return me;
        }

    }
}
