using CodeConvert.Constant;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeConvert.Core
{
    class Global
    {
        private static Global me = null;
        private Global() { }

        public static Global CreateInstance()
        {
            if (me == null)
            {
                me = new Global();
            }
            return me;
        }

        private string sourcePath = null;

        private string destinationPath = null;

        private SourceType inputType = SourceType.Undefine;

        private string inputVersion = null;

        private SourceType outputType = SourceType.Undefine;

        private string outputVersion = null;


        public string SourcePath
        {
            set {
                sourcePath = value;
            }
            get {
                return sourcePath;
            }
        }

        public string DestinationPath
        {
            set
            {
                destinationPath = value;
            }
            get
            {
                return destinationPath;
            }
        }
        public SourceType InputType
        {
            set
            {
                inputType = value;
            }
            get
            {
                return inputType;
            }
        }
        public string InputVersion
        {
            set
            {
                inputVersion = value;
            }
            get
            {
                return inputVersion;
            }
        }
        public SourceType OutputType
        {
            set
            {
                outputType = value;
            }
            get
            {
                return outputType;
            }
        }

        public string OutputVersion
        {
            set
            {
                outputVersion = value;
            }
            get
            {
                return outputVersion;
            }
        }

        public string this[string key]
        {
            set { /*value;*/ }
            get { return null; }
        }
    }
}
