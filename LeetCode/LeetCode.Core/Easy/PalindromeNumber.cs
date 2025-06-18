namespace LeetCode.Core.Easy
{
    public class PalindromeNumber
    {
        /// <summary>
        /// Determines whether the given integer is a palindrome.
        /// A palindrome is a number that reads the same forwards and backwards.
        /// Handles negative numbers, zero, and single-digit numbers as special cases.
        /// For other numbers, compares characters from both ends of the string representation.
        /// </summary>
        /// <param name="x">The integer to check.</param>
        /// <returns>True if the integer is a palindrome; otherwise, false.</returns>
        public static bool IsPalindrome(int x)
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