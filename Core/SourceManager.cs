using CodeConvert.Constant;
using CodeConvert.SourceDefend;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeConvert.Core
{
    class SourceManager
    {
        private Global global = Global.CreateInstance();
        private ASourceInOut aSourceIn;
        private ASourceInOut aSourceOut;

        public SourceManager()
        {
        }
        public bool Load()
        {
            bool res = true;
            if ((res = LoadIn()))
            {
                res = LoadOut();
            }           
            
            return res;
        }

        public bool LoadIn()
        {
            aSourceIn = SouceDefendFactory.GetIo(global.InputVersion, global.InputType);
            return true;
        }

        public bool LoadOut()
        {
            aSourceOut = SouceDefendFactory.GetIo(global.OutputVersion, global.OutputType);
            return true;
        }

        public ASourceInOut SourceIn
        {
            get { return aSourceIn; }
        }


        public ASourceInOut SourceOut
        {
            get { return aSourceOut; }
        }
    }
}
