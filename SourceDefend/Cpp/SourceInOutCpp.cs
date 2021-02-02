using CodeConvert.Constant;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeConvert.SourceDefend.Cpp
{
    [TypeNameAttribute(SourceType.Cpp)]
    class SourceInOutCpp : ASourceInOut
    {
        public override CodeType GetCode(in string str)
        {
            throw new NotImplementedException();
        }

        protected override bool CheckVersion()
        {
            Console.WriteLine(SourceType.Cpp);
            return true;
        }

        protected override void LoadDefend()
        {
        //    throw new NotImplementedException();
        }
    }
}
