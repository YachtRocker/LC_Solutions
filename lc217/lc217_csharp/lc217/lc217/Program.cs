// LC 217
// Contains Duplicate

using System;

static bool ContainsDuplicate(int[] nums) {
    int l = 0;
    int r = 1;

    Array.Sort(nums);

    while (r < nums.Length)
    {
        if (nums[l] == nums[r])
        {
            return true;
        }
        else
        {
            l += 1;
            r += 1;
        }        
    }

    return false;
}

int[] nums = { 1,1,1,3,3,4,3,2,4,2 };

Console.WriteLine(ContainsDuplicate(nums));
