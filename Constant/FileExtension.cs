using System;
using System.Collections.Generic;
using System.Text;

namespace CodeConvert.Constant
{
    class FileExtension
    {
        private string [] ext = { ".c", ".cpp", ".cs", ".java", ".js" };
        private Dictionary<string, SourceType> type = new Dictionary<string, SourceType>()
        {
           { "c", SourceType.C},
           { "cpp", SourceType.Cpp},
           { "cs", SourceType.Cs},
           { "java", SourceType.Java},
           { "js", SourceType.JS}
        };
        private static FileExtension me = null;
        private FileExtension() { }

        public string this [SourceType key]
        {
            set { /*value;*/ }
            get { return ext[(int)key]; }
        }


        public SourceType this[string key]
        {
            set { /*value;*/ }
            get { return type[key.ToLower()]; }
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
