using System;

namespace TaskManager
{
    class Program
    {
        static void Main(string[] args)
        {
            PowerTwo powerTwo = new PowerTwo();
            Console.WriteLine(powerTwo.IsPowerOfTwo(5));
            Console.WriteLine(powerTwo.IsPowerOfTwo(8));


            StringReverse stringReverse = new StringReverse();
            Console.WriteLine(stringReverse.GetReverse("Testing String Reverse"));

            StringExtenstion stringExtenstion = new StringExtenstion();
            Console.WriteLine(stringExtenstion.RepeatStringBuilderInsert("Test", 5));


            GetOddNumber getOddNumber = new GetOddNumber();
            getOddNumber.printOddNumber();

        }
    }
}
