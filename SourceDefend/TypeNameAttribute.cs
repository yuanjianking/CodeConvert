using CodeConvert.Constant;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeConvert.SourceDefend
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    class TypeNameAttribute : Attribute
    {
        private SourceType type;

        public TypeNameAttribute(SourceType type)
        {
            this.type = type;
        }

        public SourceType Type
        {
            get { return type; }
            set { type = value; }
        }
    }
}
