// Leetcode 39 - Combination Sum

// Using recursion tree

static IList<IList<int>> CombinationSum(int[] candidates, int target)
{
    
    IList<IList<int>> res = new List<IList<int>>();
    int candidatesLen = candidates.Length;  
    

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

        cur.Append(candidates[i]);
        dfs(i, cur, total, res, target, candidates);
        cur.RemoveAt(0);
        dfs(i + 1, cur, total, res, target, candidates);
    }

    return res;
}

int[] candidates = { 2, 3, 6, 7 };
int target = 7;

IList<IList<int>> res = new List<IList<int>>();  // How to print out this?

res = CombinationSum(candidates, target);

foreach (var list in res)
{
    foreach (var number in list)
    {
        Console.WriteLine(number);
    }
}
