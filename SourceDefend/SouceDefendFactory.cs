using CodeConvert.Constant;
using CodeConvert.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CodeConvert.SourceDefend
{
    class SouceDefendFactory
    {
     
        public SouceDefendFactory()
        {

        }

        public static ASourceInOut GetIo(in string version, in SourceType sourceType)
        {
            SourceType source = sourceType;
            ASourceInOut aSource = Polymorphic.CreateInstance<ASourceInOut>(t => t.FullName.Contains("CodeConvert.SourceDefend." + source.ToString()), source);

            aSource.Init(version);
            return aSource;
        }
    }
}
