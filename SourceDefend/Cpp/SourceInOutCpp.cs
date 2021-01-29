using CodeConvert.Constant;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeConvert.SourceDefend.Cpp
{
    [TypeNameAttribute(SourceType.Cpp)]
    class SourceInOutCpp : ASourceInOut
    {

        protected override bool CheckVersion()
        {
            Console.WriteLine(SourceType.Cpp);
            return true;
        }

        protected override int getA()
        {
            //  throw new NotImplementedException();
            return 0;
        }

        protected override int getB()
        {
            //   throw new NotImplementedException();
            return 0;
        }

        protected override void LoadDefend()
        {
        //    throw new NotImplementedException();
        }
    }
}
