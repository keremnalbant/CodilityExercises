using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

//A binary gap within a positive integer N is any maximal sequence of consecutive zeros that is surrounded by ones at both ends in the binary representation of N.

//For example, number 9 has binary representation 1001 and contains a binary gap of length 2. The number 529 has binary representation 1000010001 and contains two binary gaps: one of length 4 and one of length 3. The number 20 has binary representation 10100 and contains one binary gap of length 1. The number 15 has binary representation 1111 and has no binary gaps. The number 32 has binary representation 100000 and has no binary gaps.

//Write a function:

//class Solution { public int solution(int N); }

//that, given a positive integer N, returns the length of its longest binary gap. The function should return 0 if N doesn't contain a binary gap.

//For example, given N = 1041 the function should return 5, because N has binary representation 10000010001 and so its longest binary gap is of length 5. Given N = 32 the function should return 0, because N has binary representation '100000' and thus no binary gaps.

//Write an efficient algorithm for the following assumptions:

//N is an integer within the range [1..2,147,483,647].
//Copyright 2009–2022 by Codility Limited. All Rights Reserved. Unauthorized copying, publication or disclosure prohibited.

class Solution
{
    public int solution(int N)
    {
        int firstIndex = 0;
        int lastIndex = 0;
        int gapLength = 0;
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        string binary = Convert.ToString(N, 2);

        if (binary.Length < 3) { return 0; }

        for (int i = 0; i < binary.Length; i++)
        {
            if (binary[i] == '0')
            {
                int indexOf0 = i;
                //0'ı buldum sola doğru arıyorum
                for (int j = indexOf0; j >= lastIndex; j--)
                {
                    if (binary[j] == '1')
                    {
                        firstIndex = j;
                    }
                }
                //0'ı buldum sağa doğru arıyorum
                for (int k = indexOf0; k < binary.Length; k++)
                {
                    if (binary[k] == '1')
                    {
                        lastIndex = k;
                        if (lastIndex - firstIndex > gapLength) { 
                        gapLength = lastIndex - firstIndex;
                        i = lastIndex;
                        break;
                        }
                    }
                }
            }

        }

        return gapLength-1;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int number = 10432111;
        Solution solution = new Solution();
        int result = solution.solution(number);
        if (result == -1)
            Console.WriteLine(0);
        else
            Console.WriteLine(result);

    }
}