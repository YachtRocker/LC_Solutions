// Leetcode 49 - Group Anagrams

IList<IList<string>> GroupAnagrams(string[] strs)
{
    var res = new List<IList<string>>();
    List<string> cur = new List<string>();

    if (strs.Length == 0)
    {
        return res;
    }

    for (int i = 0; i < strs.Length; i++)
    {
        for (int j = 0; j < strs.Length; j++)
        {
            if (isAnagram(strs[i], strs[j]))
            {
                cur.Add(strs[j]);
            }            
        }
        res.Add(cur);
    }

    return res;
}

static bool isAnagram(string originalWord, string compareWord)
{
    char[] cw = compareWord.ToArray();
    char[] ow = originalWord.ToArray();
    Array.Sort(cw);
    Array.Sort(ow);

    if (ow.SequenceEqual(cw))
    {
        return true;
    }
    else
    {
        return false;
    }
}



string[] words = { "eat", "tea", "tan", "ate", "nat", "bat" };

IList<IList<string>> res = new List<IList<string>>();

res = GroupAnagrams(words);

foreach (var list in res)
{
    Console.Write("[");
    foreach (var number in list)
    {
        Console.Write(number);
    }
    Console.Write("]");
}