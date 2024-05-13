//-----------------------------------------------------------------------------
// Runtime: 288ms
// Memory Usage: 38.3 MB
// Link: https://leetcode.com/submissions/detail/320910763/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _049_GroupAnagrams
    {
        public IList<IList<string>> GroupAnagrams_ori(string[] strs)
        {
            var mapping = new Dictionary<string, IList<string>>();

            var key = string.Empty;
            char[] ch;
            foreach (var str in strs)
            {
                ch = str.ToCharArray();
                Array.Sort(ch);
                key = new string(ch);
                if (!mapping.ContainsKey(key))
                {
                    mapping.Add(key, new List<string>());
                }
                mapping[key].Add(str);
            }

            var result = new List<IList<string>>();
            foreach (var pair in mapping)
            {
                result.Add(pair.Value.OrderBy(s => s).ToList());
            }
            return result;
        }

        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var map = new Dictionary<string, IList<string>>();

            IList<string> strs2;
            foreach (var str in strs)
            {
                var chars = str.ToCharArray();
                Array.Sort(chars);
                var key = String.Join("", chars); // str2 = new string(chars);

                if (map.ContainsKey(key))
                {
                    map[key].Add(str);
                }
                else
                {
                    map.Add(key, new List<string>() { str });
                }
            }

            var result = new List<IList<string>>();


            return null;
        }
    }
}
