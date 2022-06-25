//class Solution3
//{
//    public bool isValid(string target)
//    {
//        if (System.Text.RegularExpressions.Regex.IsMatch(target, "^[a-zA-Z0-9]*$"))
//        {
//            int letterCounter = 0;
//            int digitCounter = 0;

//            for (int i = 0; i < target.Length; i++)
//            {
//                if (System.Text.RegularExpressions.Regex.IsMatch(target[i].ToString(), "^[a-zA-Z]*$"))
//                {
//                    letterCounter++;
//                }
//                if (System.Text.RegularExpressions.Regex.IsMatch(target[i].ToString(), "^[0-9]*$"))
//                {
//                    digitCounter++;
//                }

//            }
//            if (letterCounter % 2 == 0 && digitCounter % 2 == 1)
//                return true;
//            else
//                return false;
//        }
//        else
//            return false;
//    }

//    public int solution(string S)
//    {
//        int longestWord = -1;
//        string[] passwords = S.Split(' ');
//        if (passwords.Length == 0)
//            return -1;
//        foreach (string word in passwords)
//        {
//            bool a = isValid(word);
//            if (!a)
//                continue;
//            else
//            {
//                if (longestWord < word.Length)
//                {
//                    longestWord = word.Length;
//                }
//            }
//        }
//        return longestWord;

//    }
//}
//class Program3
//{
//    static void Main(string[] args)
//    {
//        string passwords = "asd 1234pa033 pass007 5 123vv";
//        Solution3 solution = new();
//        int result = solution.solution(passwords);
//        Console.WriteLine(result);

//    }
//}