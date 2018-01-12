using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _FileString
{
    public class MyFileString
    {
        public static string ReadF(string name)
        {
            string res = "";
            FileStream file = new FileStream(name, FileMode.Open);
            StreamReader streamReader = new StreamReader(file);
            string s = "";
            while (s != null)
            {
                res += s + '\n';
                s = streamReader.ReadLine();
            }
            streamReader.Close();
            file.Close();
            return res;
        }
        public static void WriteF(string name, string[] value)
        {

            FileStream file = new FileStream(name, FileMode.Create);
            StreamWriter streamWriter = new StreamWriter(file);
            for (int i = 0; i < value.Length; i++)
            {
                streamWriter.WriteLine(value[i]);
            }
            streamWriter.Flush();
            streamWriter.Close();
            file.Close();
        }
        public static void ClearF(string name)
        {

            FileStream file = new FileStream(name, FileMode.Create);
            file.Close();
        }
        public static void WriteF(string name, string value)
        {

            FileStream file = new FileStream(name, FileMode.Append);
            StreamWriter streamWriter = new StreamWriter(file);
            streamWriter.Flush();
            streamWriter.Write(value);
            streamWriter.Close();
            file.Close();
        }
    }
}
