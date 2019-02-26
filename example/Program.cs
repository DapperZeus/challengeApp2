using System;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNum = 9;

            string alsoNum = "0";

            var result = myNum + Convert.ToInt16(alsoNum);

            Console.WriteLine(result);
        }
    }
}
