using CodeConvert.Constant;
using CodeConvert.SourceDefend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CodeConvert.Core
{
    class Polymorphic
    {
        public static TResult CreateInstance<TResult>(in Func<Type, bool> predicate,in SourceType source)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            List<Type> typeList = assembly.GetTypes().Where(predicate).ToList();

            foreach (Type t in typeList)
            {
                object[] attributes = t.GetCustomAttributes(typeof(TypeNameAttribute), false);
                if (attributes.Length > 0)
                {
                    TypeNameAttribute typeName = (TypeNameAttribute)attributes[0];
                    if (typeName.Type == source)
                    {
                        return (TResult) Activator.CreateInstance(t);
                    }
                }
            }
            return default;

        }
    }
}
