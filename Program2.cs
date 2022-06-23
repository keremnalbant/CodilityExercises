//class Solution2
//{
//    public int solution(int[] A)
//    {
//        int lastNode = 0;
//        if (A.Length == 2)
//        {
//            return 2;
//        }
//        if (A.Length == 1)
//        {
//            return 1;
//        }
//        if (A.Length == 0)
//        {
//            return 0;
//        }
//        else
//        {
//        for (int i = 0; i < A.Length;)
//        {
//            i = A[i];
//            if (A[A[i]] == -1)
//            {
//                lastNode = i;
//                break;
//            }
//        }

//        return lastNode;
//        }
//    }
//}
//class Program2
//{
//    static void Main(string[] args)
//    {
//        int[] numbers = {1,-1};
//        Solution2 solution = new();
//        int result = solution.solution(numbers);
//        Console.WriteLine(result);

//    }
//}