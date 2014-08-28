using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Remoting_Dll 
{
    public class FileFetcher : System.MarshalByRefObject
    {
        public string GetFile(string fullPath)
        {
            string file = null;

            try
            {
                StreamReader reader = new StreamReader(fullPath);
                file = reader.ReadToEnd();
                reader.Close();
            }
            catch { }

            return file;
        }
    }
}
