using System;

namespace ArrayPracticeCodeAlong
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 15, 23, 19, 85, 97 };

            foreach(int num in nums)
            {
                if(num % 5 == 0)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}            //Search Algorithm - this would be a linear search specifically
/*Say we have this list of numbers:
10, 15, 23, 19, 85, 97
How would you write a loop that searches that array and prints every number disivible by 5*/
