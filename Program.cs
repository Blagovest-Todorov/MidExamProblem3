using System;
using System.Collections.Generic;
using System.Linq;
class WordCountingWithSortedDictionary
{
    static void Main()
    {
        List<int> ratings = Console.ReadLine()
             .Split()
             .Select(int.Parse)
             .ToList(); // read the input and make it to List

        int entryPointIdx = int.Parse(Console.ReadLine());

        string[] comandData = Console.ReadLine()
            .Split();

        string comand = comandData[0];

        int sumLeft = 0;
        int sumRight = 0;

        if (comand == "cheap")
        {
            //// Left Side 
            sumLeft = SumElementsLeft(comand, entryPointIdx, ratings);
            ////Right Side // 
            sumRight = SumElementsRight(comand, entryPointIdx, ratings);
        }
        else if (comand == "expensive")
        {
            //// Left Side 
            sumLeft = SumElementsLeft(comand, entryPointIdx, ratings);
            ////Right Side // 
            sumRight = SumElementsRight(comand, entryPointIdx, ratings);
        }

        if (sumLeft > sumRight)
        {
            Console.WriteLine($"Left - {sumLeft}");
        }
        else if (sumRight > sumLeft)
        {
            Console.WriteLine($"Right - {sumRight}");
        }
        else //if (sumRight = sumLeft)
        {
            Console.WriteLine($"Left - {sumLeft}");
        }
    }

    static int SumElementsLeft(string command, int entryPointIdx, List<int> ratings )
    {
        int sumL = 0;
       
        if (command == "cheap")
        {
            for (int i = 0; i < entryPointIdx; i++)
            {
                if (ratings[i] < ratings[entryPointIdx])
                {
                    sumL += ratings[i];
                }
            }

            return sumL;
            
        }
        else // if command = "expensive"  //Left Sum 
        {
            for (int i = 0; i < entryPointIdx; i++)
            {
                if (ratings[i] >= ratings[entryPointIdx])
                {
                    sumL += ratings[i];
                }
            }

            return sumL;
        }
    }

    static int SumElementsRight(string command, int entryPointIdx, List<int> ratings)
    {
        int sumR = 0;

        if (command == "cheap")
        {
            for (int i = entryPointIdx + 1; i < ratings.Count; i++)
            {
                if (ratings[i] < ratings[entryPointIdx])
                {
                    sumR += ratings[i];
                }
            }

            return sumR;
        }
        else  //"if command == "expensive"
        {
            for (int i = entryPointIdx + 1; i < ratings.Count; i++)
            {
                if (ratings[i] >= ratings[entryPointIdx])
                {
                    sumR += ratings[i];
                }
            }

            return sumR;
        }  
    }
}