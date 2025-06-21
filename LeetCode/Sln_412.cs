namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/fizz-buzz/
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public IList<string> FizzBuzz(int n)
        {
            bool isFizz = false; //  divisible by 3
            bool isBuzz = false; // divisible by 5

            List<string> result = new List<string>();

            for (int i = 0; i < n; i++)
            {
                int num = i + 1;
                if (num % 3 == 0)
                {
                    isFizz = true;
                }
                if (num % 5 == 0)
                {
                    isBuzz = true;
                }

                if (isFizz && isBuzz)
                {
                    result.Add("FizzBuzz");
                }
                else if (isFizz)
                {
                    result.Add("Fizz");
                }
                else if (isBuzz)
                {
                    result.Add("Buzz");
                }
                else
                {
                    result.Add(num.ToString());
                }

                isFizz = false;
                isBuzz = false;
            }

            return result;
        }
    }
}
