using System;
namespace TaskManager
{
    public class StringReverse
    {
        public string GetReverse(string text)
        {
            if (text == null) return null;
            // this was posted by petebob as well 
            char[] array = text.ToCharArray();
            Array.Reverse(array);
            return new String(array);
        }
    }
}
