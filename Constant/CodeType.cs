using System;
using System.Collections.Generic;
using System.Text;

namespace CodeConvert.Constant
{
    enum CodeType: ushort
    {
        //未定义
        T_UnDefend = 0,        
        //常数
        T_Constant,
        //标识符
        T_Identifier,

        //界符
        T_lpar = 10000,         // (
        T_Rpar,                 // )
        T_Lp,                   // {
        T_Rp,                   // }   
        /*
       ‘/*’、‘//’、 () { } [ ] " "  ' 等
        */

        //运算符
        T_Equal = 20000,        // =
        /*
            <、<=、>、>=、=、+、-、*、/、^、等
        */

        //保留字
        T_If = 30000,           // if
        /*
         auto       break    case     char        const      continue  
        default    do       double   else        enum       extern    
        float      for      goto     if          int        long      
        register   return   short    signed      sizeof     static  
        struct     switch   typedef  union       unsigned   void  
        volatile    while
         */
    }
}
