using System;
namespace TaskManager
{
    public class PowerTwo
    {
        public bool IsPowerOfTwo(int n)
        {
            return (int)(Math.Ceiling((Math.Log(n) / Math.Log(2))))
                  == (int)(Math.Floor(((Math.Log(n) / Math.Log(2)))));
        }

    }
}
