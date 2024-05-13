//-----------------------------------------------------------------------------
// Runtime: 64ms
// Memory Usage: 15.9 MB
// Link: https://leetcode.com/submissions/detail/351897898/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _009_PalindromeNumber
    {
        public bool IsPalindrome_ori(int x)
        {
            if (x < 0) { return false; } // negative digit
            if (x < 10) { return true; } // single digit

            var temp = x;
            var y = 0;
            var digit = 0;
            while (temp != 0)
            {
                digit = temp % 10; // get the remainder of temp, base 10. why 10? because of tenth(puluh) number
                y = y * 10 + digit; // nak tambah kosong kat belakang current number. eg, now 3, then 3*10 = 30 + current digit 2 = 32
                temp /= 10; // temp = temp / 10, 
            }

            return x == y;
        }

        public bool IsPalindrome(int x)
        {
            /// number has to be positive
            /// any single digit number will be considered as true
            /// 1. get last digit (y) but getting remainder of x
            /// 2. append y value from last digit, with product of tenth
            /// 3. update latest value by removing last digit and loop all the x digits
            
            if (x < 0) { return false;  }
            if (x < 10) { return true; }

            int lastDigit = 0;
            int y = 0;
            int temp = x;

            while (temp != 0)
            {
                lastDigit = temp % 10;
                y = (y * 10) + lastDigit;
                temp /= 10;
            }

            return x == y;
        }
    }
}
