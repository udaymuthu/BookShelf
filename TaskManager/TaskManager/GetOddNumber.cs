using System;
namespace TaskManager
{
    public class GetOddNumber
    {
        public void printOddNumber() {
            for (int i = 0; i <= 100; i++)
            {
                if ((i & 1) == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
}
