//class Solution4
//{
//    public int solution(int[] A)
//    {
//        int n = A.Length;
//        int res = 0;
//        int[] depths = new int[n];
//        int wall = A[0];

//        for (int i = 1; i < n - 1; ++i)
//        {
//            if (A[i] > wall)
//                wall = A[i];
//            else
//                depths[i] = wall - A[i];
//        }

//        wall = A[n - 1];

//        for (int i = n - 2; i > 0; --i)
//        {
//            if (A[i] > wall)
//            {
//                wall = A[i];
//                depths[i] = 0;
//            }
//            else
//                depths[i] = Math.Min(wall - A[i], depths[i]);

//            res = Math.Max(res, depths[i]);
//        }
//        return res;
//    }
//}
//class Program4
//{
//    static void Main(string[] args)
//    {
//        int[] blocks = { 1, 3, 2, 1, 2, 1, 5, 3, 3, 4, 2 };
//        Solution4 solution = new();
//        int result = solution.solution(blocks);
//        Console.WriteLine(result);
//    }
//}