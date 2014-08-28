using System;
using System.Collections.Generic;
using System.Text;

namespace FilesSharing
{
    [Serializable]
    public class SearchInfo
    {
        public string WordToSearch;
        public string[] Suffixes;

        public SearchInfo(string[] suffixes, string word2Search)
        {
            WordToSearch = word2Search;
            Suffixes = suffixes;
        }
    }
}
