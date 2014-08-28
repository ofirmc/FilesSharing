using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace FilesSharing
{
    [Serializable]
    public class Filedata
    {
        public string FileName;//"My Person"
        public string Path;//"C:\\Program files\My folder"
        public string Extension;//".cs"
        public int Size;

        public Filedata()
        {

        }
        public Filedata(string fullName)
        {
            GetFileData(fullName);
        }

        //Get all the date on a file.
        public void GetFileData(string fullName)
        {
            FileInfo fi = new FileInfo(fullName);
            FileName = fi.Name.Remove(fi.Name.LastIndexOf(fi.Extension));
            Path = fi.DirectoryName;
            Extension = fi.Extension;
            Size = (int)fi.Length;
            
        }
        public string FullName
        {
            get
            {
                return Path + "\\" + FileName + Extension;
            }
        }
    }
}
