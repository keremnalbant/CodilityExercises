class Solution5
{
    public int lengthOfLIS(long[] nums)
    {
        long[] temp = new long[nums.Length];
        int idx = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            int fnd = Array.BinarySearch(temp, 0, idx, nums[i]);

            if (fnd < 0)
            {
                fnd = -fnd - 1;
            }

            if (fnd == idx)
            {
                idx++;
            }

            temp[fnd] = nums[i];
        }
        return idx;
    }

    public int solution(int[] A)
    {
        long bound = A.Max();
        long[] withMirrors = new long[A.Length * 3];
        for (int i = 0; i < A.Length; i++)
        {
            withMirrors[i * 3] = bound * 2 + A[i] + 1;
            withMirrors[i * 3 + 1] = bound * 2 - A[i] + 1;
            withMirrors[i * 3 + 2] = A[i];
        }
        return lengthOfLIS(withMirrors);
    }

}


class Program4
{
    static void Main(string[] args)
    {
        int[] a = { 15, 13, 5, 7, 4, 10, 12, 8, 2, 11, 6, 9, 3 };
        Solution5 solution = new();
        int result = solution.solution(a);
        Console.WriteLine(result);
    }
}