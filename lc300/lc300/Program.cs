// Leetcode 300

int[] lst = { 10, 9, 2, 5, 3, 7, 101, 18 }; // Returns 4
Console.WriteLine(LengthOfLIS(lst));

static int LengthOfLIS(int[] nums)
{
    List<int> LIS = new List<int>();

    for (int i = 0; i < nums.Length; i++)
    {
        LIS.Add(1);
    }

    for (int i = nums.Length - 1; i >= 0; i--)
    {
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (nums[i] < nums[j])
            {
                LIS[i] = Math.Max(LIS[i], 1 + LIS[j]);
            }
        }
    }

    return LIS.Max();
}




