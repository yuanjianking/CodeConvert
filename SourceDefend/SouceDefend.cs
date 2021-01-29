using CodeConvert.Constant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CodeConvert.SourceDefend
{
    class SouceDefend
    {
        private string  version;
        private SourceType sourceType = SourceType.Undefine;
        public SouceDefend(string version, SourceType type)
        {
            this.version = version;
            this.sourceType = type;
        }

        public ASourceInOut GetIo()
        {
            ASourceInOut aSource = null;
            Assembly assembly = Assembly.GetExecutingAssembly();
            List<Type> typeList = assembly.GetTypes().Where(t => t.FullName.Contains(MethodBase.GetCurrentMethod().DeclaringType.Namespace) && t.Name.Contains(sourceType.ToString())).ToList();

            foreach (Type t in typeList)
            {
                object[] attributes = t.GetCustomAttributes(typeof(TypeNameAttribute), false);
                if (attributes.Length > 0)
                {
                    TypeNameAttribute typeName = (TypeNameAttribute)attributes[0];
                    if(typeName.Type == sourceType)
                    { 
                        aSource = Activator.CreateInstance(t) as ASourceInOut;
                        break;
                    }
                }
            }
            aSource.Init(version);
            return aSource;
        }
    }
}
