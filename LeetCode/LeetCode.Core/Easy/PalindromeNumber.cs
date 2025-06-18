namespace LeetCode.Core.Easy
{
    public class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false; // Negative numbers are not palindromes
            }

            if (x == 0)
            {
                return true; // 0 is a palindrome
            }

            if (x < 10)
            {
                return true; // Single digit numbers are palindromes
            }

            // Convert the number to a string and check if it reads the same forwards and backwards
            string str = x.ToString();
            int left = 0;
            int right = str.Length - 1;
            while (left < right)
            {
                if (str[left] != str[right])
                {
                    return false; // Mismatch found, not a palindrome
                }
                left++;
                right--;
            }

            return true;
        }
    }
}