// Leetcode 39 - Combination Sum

// DFS = Depth First Search

static IList<IList<int>> CombinationSum(int[] candidates, int target)
{    
    var res = new List<IList<int>>();    
    
    if (candidates.Length == 0)
    {
        return res;
    }

    Array.Sort(candidates);

    dfs(candidates, target, 0, new List<int>(), res);

    return res;
}


static void dfs(int[] candidates, int target, int start, IList<int> oneResult, IList<IList<int>> result)
{
    if(target == 0)
    {
        result.Add(new List<int>(oneResult)); 
    }
    else if(target > 0)
    {
        for (int i = start; i < candidates.Length; i++)
        {
            oneResult.Add(candidates[i]);
            dfs(candidates, target - candidates[i], i, oneResult, result);
            oneResult.RemoveAt(oneResult.Count - 1);
        }   
    }
}




int[] candidates = { 2, 3, 5 };
int target = 8;

IList<IList<int>> res = new List<IList<int>>();  

res = CombinationSum(candidates, target);

foreach (var list in res)
{
    Console.Write("[");
    foreach (var number in list)
    {
        Console.Write(number);
    }
    Console.Write("]");

}

// TODO - Make a nice printout

