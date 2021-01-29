using CodeConvert.Constant;
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
            ASourceInOut aSource = null;
            Assembly assembly = Assembly.GetExecutingAssembly();
            List<Type> typeList = assembly.GetTypes().Where(t => t.FullName.Contains(MethodBase.GetCurrentMethod().DeclaringType.Namespace) && t.Name.Contains(source.ToString())).ToList();

            foreach (Type t in typeList)
            {
                object[] attributes = t.GetCustomAttributes(typeof(TypeNameAttribute), false);
                if (attributes.Length > 0)
                {
                    TypeNameAttribute typeName = (TypeNameAttribute)attributes[0];
                    if(typeName.Type == source)
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
