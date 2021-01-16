using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CodeConvert.Core
{
    class FileWriter
    {
        public void Write(in string [] lines, in string path )
        {
            using (StreamWriter file = new StreamWriter(path, false, Encoding.UTF8))
            {
                foreach (string line in lines)
                {
                    file.WriteLine(line);
                }
            }
        }
        public void WriteAllLines(in string[] lines, in string path)
        {
            File.WriteAllLines(path, lines, Encoding.UTF8);
        }

        public bool DeleteDirectory(in string path)
        {
            bool res = true;
            if (Directory.Exists(path))
            {
                try
                {
                    Directory.Delete(@"C:\Users\Public\DeleteTest", true);
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.Message);
                    res = false;
                }
            }
            return res;
        }


        public void CreateDirectory(in string path, in string subpath = null)
        {
            string pathString = "";

            if (subpath is null)
            {
                pathString = path; 
            }
            else
            {
                pathString =  Path.Combine(path, subpath);
            }
            
            Directory.CreateDirectory(pathString);
        }
    }
}
