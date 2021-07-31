using CodeConvert.Constant;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeConvert.SourceDefend.Cpp
{
    [TypeNameAttribute(SourceType.Cpp)]
    class SourceInOutCpp : ASourceInOut
    {
        public override T GetCode<T>(in string word)
        {
            throw new NotImplementedException();
        }

        public override bool HasCode<T>(in string word, ref T code)
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
