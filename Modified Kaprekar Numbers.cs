using System;
using System.Collections.Generic;

class Result
{
    public static void kaprekarNumbers(int p, int q)
    {
        List<long> kaprekarList = new List<long>();
        
        for (long i = p; i <= q; i++)
        {
            long square = i * i;
            string squareString = square.ToString();
            int digitCount = i.ToString().Length;
            
            int splitPoint = squareString.Length - digitCount;
            string leftPart = (splitPoint > 0) ? squareString.Substring(0, splitPoint) : "0";
            string rightPart = squareString.Substring(splitPoint);
            
            long leftNum = long.Parse(leftPart);
            long rightNum = long.Parse(rightPart);
            
            
            if (leftNum + rightNum == i && rightNum > 0)
            {
                kaprekarList.Add(i);
            }
        }
        
        if (kaprekarList.Count > 0)
        {
            Console.WriteLine(string.Join(" ", kaprekarList));
        }
        else
        {
            Console.WriteLine("INVALID RANGE");
        }
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int p = Convert.ToInt32(Console.ReadLine().Trim());
        int q = Convert.ToInt32(Console.ReadLine().Trim());
        
        Result.kaprekarNumbers(p, q);
    }
}
