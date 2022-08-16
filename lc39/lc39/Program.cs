// Leetcode 39 - Combination Sum

// DFS

static IList<IList<int>> CombinationSum(int[] candidates, int target)
{
    
    IList<IList<int>> res = new List<IList<int>>();
    List<int> cur = new List<int>();    

    static void dfs(int i, List<int> cur, int total, IList<IList<int>> res, int target, int[] candidates)
    {
        if (total == target)
        {
            res.Add(cur);
            return;
        }
        if (i >= candidates.Length || total > target)
        {
            return;
        }

        cur.Add(candidates[i]);
        dfs(i, cur, total, res, target, candidates);
        cur.RemoveAt(0);
        dfs(i + 1, cur, total, res, target, candidates);
    }

    dfs(0, cur, 0, res, target, candidates);

    return res;
}





int[] candidates = { 2, 3, 6, 7 };
int target = 7;

IList<IList<int>> res = new List<IList<int>>();  

res = CombinationSum(candidates, target);

foreach (var list in res)
{
    foreach (var number in list)
    {
        Console.WriteLine(number);
    }
}

// TODO - Nothing is being output figure out why
// TODO - Stack Overflow, just keeps looping
