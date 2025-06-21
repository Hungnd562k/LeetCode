namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/ransom-note/
        /// </summary>
        /// <param name="ransomNote"></param>
        /// <param name="magazine"></param>
        /// <returns></returns>
        public bool CanConstruct(string ransomNote, string magazine)
        {
            Dictionary<string, int> magazineLetters = new Dictionary<string, int>();
            int i = 0;
            char currentLetter = '\0';

            for (i = 0; i < magazine.Length; i++)
            {
                currentLetter = magazine.ToCharArray()[i];
                if (magazineLetters.ContainsKey(currentLetter.ToString()))
                {
                    magazineLetters[currentLetter.ToString()]++;
                }
                else
                {
                    magazineLetters.Add(currentLetter.ToString(), 1);
                }
            }

            for (i = 0; i < ransomNote.Length; i++)
            {
                currentLetter = ransomNote.ToCharArray()[i];
                if (magazineLetters.ContainsKey(currentLetter.ToString()))
                {
                    if (magazineLetters[currentLetter.ToString()] == 0)
                    {
                        return false;
                    }
                    else
                    {
                        magazineLetters[currentLetter.ToString()]--;
                    }
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
