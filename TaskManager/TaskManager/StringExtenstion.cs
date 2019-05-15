using System;
using System.Text;

namespace TaskManager
{
    public class StringExtenstion
    {

        public string RepeatStringBuilderInsert(string s, int n)
        {
            return new StringBuilder(s.Length * n)
                        .Insert(0, s, n)
                        .ToString();
        }
    }
}
