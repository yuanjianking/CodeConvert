using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CodeConvert.Core
{
    class FileReader
    {
        public bool Read(in string path, in Func<string, bool> func )
        {
            bool res = true;
            using (StreamReader sr = new StreamReader(path, Encoding.UTF8))
            {
                String line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (!func.Invoke(line))
                    {
                        res = false;
                        break;
                    }
                }
            }
            return res;
        }

        public string[] ReadAllLines(in string path)
        {
            string[] lines = File.ReadAllLines(path, Encoding.UTF8);
            return lines;
        }

        public IEnumerable<FileInfo> WalkDirectoryTree(string path)
        {
            DirectoryInfo root = new DirectoryInfo(path);
            FileInfo[] files = null;
            DirectoryInfo[] subDirs = null;

            // First, process all the files directly under this folder
            try
            {
                files = root.GetFiles("*.*");
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (System.IO.DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            if (files != null)
            {
                foreach (FileInfo fi in files)
                {
                    yield return fi;
                }

                subDirs = root.GetDirectories();

                foreach (DirectoryInfo dirInfo in subDirs)
                {
                    foreach (FileInfo info in WalkDirectoryTree(dirInfo.FullName))
                    {
                        yield return info;
                    }
                }
            }
            else
            {
                yield return null;
            }
        }
    }
}
