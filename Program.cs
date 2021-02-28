using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] nums = Console.ReadLine()   // Line 1
                .Split(' ')
                .Select(long.Parse)
                .ToArray(); // Array ratings

            List<long> leftSum = new List<long>(nums.Length);
            List<long> rightSum = new List<long>(nums.Length);

            long leftSu = 0;
            long rightSu = 0;

            long entryPointIdx = long.Parse(Console.ReadLine()); //Line 2
            // int EntryPoint  >= 0 and < PenaltyelementIdx 
            long intBreakLength = entryPointIdx;

            string typeItem = Console.ReadLine(); //Line 3

            if (typeItem == "cheap")   // typeItem -- > Position 
            {
                // Left 
                for (long i = 0; i < entryPointIdx; i++)
                {
                    long curItem = nums[i];

                    if (nums[i] < nums[entryPointIdx])   // nums[entryPointIdx]
                    {
                        leftSum.Add(nums[i]);   //adding to Array
                    }
                }

                // Console.WriteLine(leftSum.Sum());
                leftSu = leftSum.Sum();
                ///// Right
                for (long i = nums.Length - 1; i > entryPointIdx; i--)
                {
                    long curItem = nums[i];

                    if (nums[i] < nums[entryPointIdx])
                    {
                        rightSum.Add(nums[i]);
                    }
                }

                rightSu = rightSum.Sum();                
            }
            else // (typeItem == "expensive")
            {
                for (long i = 0; i < entryPointIdx; i++)  //Left from entryPoint
                {
                    if (nums[i] >= nums[entryPointIdx])
                    {
                        leftSum.Add(nums[i]);
                    }
                }

                leftSu = leftSum.Sum();
                /// Right
                
                for (long i = entryPointIdx + 1; i < nums.Length ; i++)  //Right from entryPoint
                {
                    if (nums[i] >= nums[entryPointIdx])
                    {
                        rightSum.Add(nums[i]);
                    }
                }

                rightSu = rightSum.Sum();
            }
            // now to Check Compare the Right and  Left Sum  and Print the Result 
            if (rightSu > leftSu)  // We make the check at end
            {

                Console.WriteLine($"Right - {rightSu}");
            }
            else if (rightSu < leftSu)
            {
                Console.WriteLine($"Left - {leftSu}");
            }
            else // Left == Right
            {
                Console.WriteLine($"Left - {leftSu}");
            }
        }
    }
}
