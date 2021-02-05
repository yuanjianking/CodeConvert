using System;
using System.Collections.Generic;
using System.Text;

namespace CodeConvert.Constant
{
    enum CodeType: ushort
    {
        //未定义
        T_A_UNDEFEND = 0,        
        //常数
        T_A_CONSTANT,
        //标识符
        T_A_IDENTIFIER,

        //界符
        #region
        /// <summary>
        /// "@"
        /// </summary>
        T_BOUND_AT = 10000,
        /// <summary>
        /// "$"
        /// </summary>
        T_BOUND_DOLLAR,
        /// <summary>
        /// "."
        /// </summary>
        T_BOUND_PERIOD,
        /// <summary>
        /// "["
        /// </summary>
        T_BOUND_BRACKETLEFT,
        /// <summary>
        /// "]"
        /// </summary>
        T_BOUND_BRACKETRIGHT,
        /// <summary>
        /// "("
        /// </summary>
        T_BOUND_PARENTLEFT,
        /// <summary>
        /// ")"
        /// </summary>
        T_BOUND_PARENTRUGHT,
        /// <summary>
        /// "{"
        /// </summary>
        T_BOUND_BRACELEFT,
        /// <summary>
        /// "}"
        /// </summary>
        T_BOUND_BRACERIGHT,
        /// <summary>
        /// ";"
        /// </summary>
        T_BOUND_SEMICOLON,
        /// <summary>
        /// ","
        /// </summary>
        T_BOUND_QUOTE,
        /// <summary>
        /// "\\"
        /// </summary>
        T_BOUND_BACKSLASH,
        /// <summary>
        /// "//"
        /// </summary>
        T_BOUND_DOUBLESLASH,
        /// <summary>
        /// "/*"
        /// </summary>
        T_BOUND_SLASHSTAR,
        /// <summary>
        /// "*/"
        /// </summary>
        T_BOUND_STARSLASH,
        /// <summary>
        /// "::"
        /// </summary> 
        T_BOUND_EQUALS,
        /// <summary>
        /// "=>"
        /// </summary>
        T_BOUND_ARROW,
        /// <summary>
        /// "->"
        /// </summary>
        T_BOUND_POINTER,
        /// <summary>
        /// ".."
        /// </summary>
        T_BOUND_ELLIPSIS,
        /// <summary>
        /// "///"
        /// </summary>
        T_BOUND_HTREESLASH,
        #endregion

        //运算符
        #region
        /// <summary>
        /// "?" 
        /// </summary>
        T_OPERATION_QUESTION = 20000,
        /// <summary>
        /// ":"
        /// </summary>
        T_OPERATION_COLON,
        /// <summary>
        /// "="
        /// </summary>
        T_OPERATION_EQUAL,
        /// <summary>
        /// "&"
        /// </summary>
        T_OPERATION_AND,
        /// <summary>
        /// "*"
        /// </summary>
        T_OPERATION_STAR,
        /// <summary>
        /// "+"
        /// </summary>
        T_OPERATION_PLUS,
        /// <summary>
        /// "-"
        /// </summary>
        T_OPERATION_MINUS,
        /// <summary>
        /// "/"
        /// </summary>
        T_OPERATION_SLASH,
        /// <summary>
        /// "%"
        /// </summary>
        T_OPERATION_PERCENT,
        /// <summary>
        /// ">"
        /// </summary>
        T_OPERATION_GREATER,
        /// <summary>
        /// "<"
        /// </summary>
        T_OPERATION_LESS,
        /// <summary>
        /// "^"
        /// </summary>
        T_OPERATION_CARET,
        /// <summary>
        /// "~"
        /// </summary>
        T_OPERATION_TILDE,
        /// <summary>
        /// "|"
        /// </summary>
        T_OPERATION_BAR,
        /// <summary>
        /// "!"
        /// </summary>
        T_OPERATION_EXCLAM,
        /// <summary>
        /// "??"
        /// </summary>
        T_OPERATION_DOUBLEQUESTION,
        /// <summary>
        /// "-="
        /// </summary>
        T_OPERATION_MINUSEQUAL,
        /// <summary>
        /// "+="
        /// </summary>
        T_OPERATION_PLUSEQUAL,
        /// <summary>
        /// "++"
        /// </summary>
        T_OPERATION_DOUBLEPLUS,
        /// <summary>
        /// "--"
        /// </summary>
        T_OPERATION_DOUBLEMINUS,
        /// <summary>
        /// "=="
        /// </summary>
        T_OPERATION_DOUBLEEQUAL,
        /// <summary>
        /// "!="
        /// </summary>
        T_OPERATION_EXCLAMEQUAL,
        /// <summary>
        /// ">="
        /// </summary>
        T_OPERATION_GREATEREQUAL,
        /// <summary>
        /// "<="
        /// </summary>
        T_OPERATION_LESSEQUAL,
        /// <summary>
        /// ">>"
        /// </summary>
        T_OPERATION_DOUBLEGREATER,
        /// <summary>
        /// "<<"
        /// </summary>
        T_OPERATION_DOUBLELESS,
        /// <summary>
        /// "||" 
        /// </summary>
        T_OPERATION_DOUBLEBAR,
        /// <summary>
        /// "&&"
        /// </summary>
        T_OPERATION_DOUBLEAND,
        /// <summary>
        /// "??=" 
        /// </summary>
        T_OPERATION_DOUBLEQUESTIONEQUAL,

        #endregion

        //保留字
        #region  
        T_PERSIST_ABSTRACT = 30000,
        T_PERSIST_AS,
        T_PERSIST_BASE,
        T_PERSIST_BOOL,
        T_PERSIST_BREAK,
        T_PERSIST_BYTE,
        T_PERSIST_CASE,
        T_PERSIST_CATCH,
        T_PERSIST_CHAR,
        T_PERSIST_CHECKED,
        T_PERSIST_CLASS,
        T_PERSIST_CONST,
        T_PERSIST_CONTINUE,
        T_PERSIST_DECIMAL,
        T_PERSIST_DEFAULT,
        T_PERSIST_DELEGATE,
        T_PERSIST_DO,
        T_PERSIST_DOUBLE,
        T_PERSIST_ELSE,
        T_PERSIST_ENUM,
        T_PERSIST_EVENT,
        T_PERSIST_EXPLICIT,
        T_PERSIST_EXTERN,
        T_PERSIST_FALSE,
        T_PERSIST_FINALLY,
        T_PERSIST_FIXED,
        T_PERSIST_FLOAT,
        T_PERSIST_FOR,
        T_PERSIST_FOREACH,
        T_PERSIST_GOTO,
        T_PERSIST_IF,
        T_PERSIST_IMPLICIT,
        T_PERSIST_IN,
        T_PERSIST_INT,
        T_PERSIST_INTERFACE,
        T_PERSIST_INTERNAL,
        T_PERSIST_IS,
        T_PERSIST_LOCK,
        T_PERSIST_LONG,
        T_PERSIST_NAMESPACE,
        T_PERSIST_NEW,
        T_PERSIST_NULL,
        T_PERSIST_OBJECT,
        T_PERSIST_OPERATOR,
        T_PERSIST_OUT,
        T_PERSIST_OVERRIDE,
        T_PERSIST_PARAMS,
        T_PERSIST_PRIVATE,
        T_PERSIST_PROTECTED,
        T_PERSIST_PUBLIC,
        T_PERSIST_READONLY,
        T_PERSIST_REF,
        T_PERSIST_RETURN,
        T_PERSIST_SBYTE,
        T_PERSIST_SEALED,
        T_PERSIST_SHORT,
        T_PERSIST_SIZEOF,
        T_PERSIST_STACKALLOC,
        T_PERSIST_STATIC,
        T_PERSIST_STRING,
        T_PERSIST_STRUCT,
        T_PERSIST_SWITCH,
        T_PERSIST_THIS,
        T_PERSIST_THROW,
        T_PERSIST_TRUE,
        T_PERSIST_TRY,
        T_PERSIST_TYPEOF,
        T_PERSIST_UINT,
        T_PERSIST_ULONG,
        T_PERSIST_UNCHECKED,
        T_PERSIST_UNSAFE,
        T_PERSIST_USHORT,
        T_PERSIST_USING,
        T_PERSIST_VIRTUAL,
        T_PERSIST_VOID,
        T_PERSIST_VOLATILE,
        T_PERSIST_WHILE,
        T_PERSIST_ADD,
        T_PERSIST_ALIAS,
        T_PERSIST_ASCENDING,
        T_PERSIST_ASYNC,
        T_PERSIST_AWAIT,
        T_PERSIST_BY,
        T_PERSIST_DESCENDING,
        T_PERSIST_DYNAMIC,
        T_PERSIST_EQUALS,
        T_PERSIST_FROM,
        T_PERSIST_GET,
        T_PERSIST_GLOBAL,
        T_PERSIST_GROUP,
        T_PERSIST_INTO,
        T_PERSIST_JOIN,
        T_PERSIST_LET,
        T_PERSIST_NAMEOF,
        T_PERSIST_NOTNULL,
        T_PERSIST_ON,
        T_PERSIST_ORDERBY,
        T_PERSIST_PARTIAL,
        T_PERSIST_REMOVE,
        T_PERSIST_SELECT,
        T_PERSIST_SET,
        T_PERSIST_UNMANAGED,
        T_PERSIST_VALUE,
        T_PERSIST_VAR,
        T_PERSIST_WHEN,
        T_PERSIST_WHERE,
        T_PERSIST_WITH,
        T_PERSIST_YIELD,
        #endregion

        // 预处理
        #region
        T_SHARP_IF = 40000,
        T_SHARP_ELSE,
        T_SHARP_ELIF,
        T_SHARP_ENDIF,
        T_SHARP_DEFINE,
        T_SHARP_UNDEF,
        T_SHARP_WARNING,
        T_SHARP_ERROR,
        T_SHARP_LINE,
        T_SHARP_NULLABLE,
        T_SHARP_REGION,
        T_SHARP_ENDREGION,
        T_SHARP_PRAGMA,
        T_SHARP_PRAGMAWARNING,
        T_SHARP_PRAGMACHECKSUM,
        #endregion
    }
}