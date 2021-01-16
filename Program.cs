using CodeConvert.Core;
using System;
using Convert = CodeConvert.Core.Convert;

namespace CodeConvert
{
    class Program
    {        
        static void Main(string[] args)
        {

            //int[] a = new int[5] { 10, 20, 30, 40, 50 };
            //unsafe
            //{
            //    fixed (int* p = &a[0])
            //    {
            //        // p is pinned as well as object, so create another pointer to show incrementing it.
            //        int* p2 = p;
            //        Console.WriteLine(*p2);
            //        // Incrementing p2 bumps the pointer by four bytes due to its type ...
            //        p2 += 1;
            //        Console.WriteLine(*p2);
            //        p2 += 1;
            //        Console.WriteLine(*p2);
            //        Console.WriteLine("--------");
            //        Console.WriteLine(*p);
            //        // Dereferencing p and incrementing changes the value of a[0] ...
            //        *p += 1;
            //        Console.WriteLine(*p);
            //        *p += 1;
            //        Console.WriteLine(*p);
            //    }
            //}

            if (args != null)
            {
                int argsLength = args.Length;
                for (int i = 0; i < argsLength; i += 2)
                {
                    string arg = args[i];
                    char[] c = arg.ToCharArray();
                    if ('-'.Equals(c[0]))
                    {
                        switch (c[1])
                        {
                            case 's':
                                if(!SetSourcePath(args[i + 1])) return;
                                break;
                            case 'd':
                                if(!SetDestinationPath(args[i + 1])) return;
                                break;
                            case 'i':
                                if(!SetInputType(args[i + 1])) return;
                                break;
                            case 'o':
                                if(!SetOutputType(args[i + 1])) return;
                                break;
                            default:
                                Console.WriteLine("Wrong Parameters.No Prefix");
                                return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong Prefix.");
                        return; 
                    }
                }
            }
            else
            {
                Console.WriteLine("Insufficient Parameters.");
                return;
            }
            Convert.Run();
            Console.WriteLine("Complete!");
        }

        private static bool CheckArg(string arg)
        {
            bool res = true;
            if (string.IsNullOrEmpty(arg))
            {
                Console.WriteLine("Wrong Prefix.No Arg");
                res = false;
            }
            else if ('-'.Equals(arg.ToCharArray()[0]))
            {
                Console.WriteLine("Wrong Prefix.No Arg");
                res = false;
            }
            return res;
        }


        private static bool SetSourcePath(string path)
        {
            bool res = true;
            if (CheckArg(path))
            {
                Global.CreateInstance().SourcePath = path;
            }
            else
            {
                res = false;
            }
            return res;
        }
        private static bool SetDestinationPath(string path)
        {
            bool res = true;
            if (CheckArg(path))
            {
                Global.CreateInstance().DestinationPath = path;
            }
            else
            {
                res = false;
            }
            return res;
        }
        private static bool SetInputType(string inType)
        {
            bool res = true;
            if (CheckArg(inType))
            {
                Global.CreateInstance().InputType = inType;
            }
            else
            {
                res = false;
            }
            return res;
        }
        private static bool SetOutputType(string outType)
        {
            bool res = true;
            if (CheckArg(outType))
            {
                Global.CreateInstance().OutputType = outType;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
