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

        private string inputType = null;

        private string outputType = null;


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
        public string InputType
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
        public string OutputType
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

        public string this[string key]
        {
            set { /*value;*/ }
            get { return null; }
        }
    }
}
