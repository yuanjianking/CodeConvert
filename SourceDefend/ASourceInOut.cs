using System;
using System.Collections.Generic;
using System.Text;

namespace CodeConvert.SourceDefend
{
    abstract class ASourceInOut
    {
        private string version;

        protected abstract bool CheckVersion();

        protected abstract void LoadDefend();

        protected abstract int getA();
        protected abstract int getB();

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
