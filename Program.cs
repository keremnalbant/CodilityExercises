//class Solution
//{

//    static string convertToBinary(int number)
//    {
//        int decimalNumber = number;

//        int remainder;
//        string result = string.Empty;
//        while (decimalNumber > 0)
//        {
//            remainder = decimalNumber % 2;
//            decimalNumber /= 2;
//            result = remainder.ToString() + result;
//        }
//        return result;
//    }

//    public int solution(int N)
//    {
//        int firstIndex = 0;
//        int lastIndex = 0;
//        int gapLength = 0;
//        // write your code in C# 6.0 with .NET 4.5 (Mono)
//        string binary = convertToBinary(N);


//        if (binary.Length < 3) { return 0; }

//        for (int i = 0; i < binary.Length; i++)
//        {
//            if (binary[i] == '0')
//            {
//                int indexOf0 = i;
//                //0'ı buldum sola doğru arıyorum
//                for (int j = indexOf0; j >= lastIndex; j--)
//                {
//                    if (binary[j] == '1')
//                    {
//                        firstIndex = j;
//                    }
//                }
//                //0'ı buldum sağa doğru arıyorum
//                for (int k = indexOf0; k < binary.Length; k++)
//                {
//                    if (binary[k] == '1')
//                    {
//                        lastIndex = k;
//                        if (lastIndex - firstIndex > gapLength)
//                        {
//                            gapLength = lastIndex - firstIndex;
//                            i = lastIndex;
//                            break;
//                        }
//                    }
//                }
//            }

//        }

//        return gapLength - 1;
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        int number = 529;
//        Solution solution = new Solution();
//        int result = solution.solution(number);
//        if (result == -1)
//            Console.WriteLine(0);
//        else
//            Console.WriteLine(result);

//    }
//}