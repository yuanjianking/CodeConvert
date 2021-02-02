using CodeConvert.Constant;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeConvert.SourceDefend
{
    abstract class ASourceInOut
    {
        private string version = "1.0";

        protected abstract bool CheckVersion();

        protected abstract void LoadDefend();

        public abstract CodeType GetCode(in string str);

        public void Init(string version)
        {
            this.version = version;
            if (CheckVersion())
            {
                LoadDefend();
            }
        }

        public string Version
        {
            set { version = value; }
            get { return version; }
        }
    }
}
