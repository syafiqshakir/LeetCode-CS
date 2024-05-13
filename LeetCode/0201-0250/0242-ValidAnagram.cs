//-----------------------------------------------------------------------------
// Runtime: 68ms
// Memory Usage: 23.8 MB
// Link: https://leetcode.com/submissions/detail/340983796/
//-----------------------------------------------------------------------------

using System;
using System.Linq;

namespace LeetCode
{
    public class _0242_ValidAnagram
    {
        public bool IsAnagram_ori(string s, string t)
        {
            if (s.Length != t.Length) return false; // immediately false if not same length

            var sCount = new int[26]; // abc has 26 letters, but what if we include unicode?
            foreach (var ch in s)
                sCount[ch - 'a']++;

            var tCount = new int[26];
            foreach (var ch in t)
                tCount[ch - 'a']++;

            return sCount.SequenceEqual(tCount);
        }

        public bool IsAnagram(string s, string t)
        {
            var sChar = s.ToCharArray();
            var tChar = t.ToCharArray();

            Array.Sort(sChar);
            Array.Sort(tChar);

            s = String.Join("", sChar);
            t = String.Join("", tChar);

            return s == t;

        }

        public bool IsAnagram_test(string s, string t)
        {
            if (s.Length != t.Length) return false;

            var sCount = new int[26];
            foreach (char c in s)
                sCount[c - 'a']++;

            var tCount = new int[26];
            foreach (char c in t)
                tCount[c - 'a']++;

            return sCount.SequenceEqual(tCount);
        }
    }
}
