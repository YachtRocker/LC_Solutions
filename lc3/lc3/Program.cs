// Leetcode solution for LC3
// Sliding window
// O(n)



 int LengthOfLongestSubstring(string s)
{
    HashSet<char> charSet = new HashSet<char>();
    int left = 0;
    int result = 0;
    for (int right = 0; right < s.Length; right++)
    {
        while (charSet.Contains(s[right]))
        {
            charSet.Remove(s[left]);
            left += 1;
        }
        charSet.Add(s[right]);
        result = Math.Max(result, right - left + 1);
    }

    return result;  
}

Console.WriteLine(LengthOfLongestSubstring("abcabcbb"));