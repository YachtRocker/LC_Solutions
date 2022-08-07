
// Solution for Leetcode 15 

//int[] nums = {-1, 0, 1, 2, -1, -4};
IList<IList<int>> output = ThreeSum(new int[] {-1,0,1,2,-1,-4});

foreach (var item in output)
{
    foreach (var x in item)
    {
        Console.Write(x + " ");
    }
}


IList<IList<int>> ThreeSum(int[] nums) {
        var result = new List<IList<int>>();
        Array.Sort(nums);
        int sum3 = 0;

        int i = -1;
        foreach (int x in nums)
        {
            i += 1;
            if (i > 0 && x == nums[i - 1])
            {
                continue;
            }

            int left = i + 1;
            int right = nums.Length - 1;

            while (left < right)
            {
                sum3 = x + nums[left] + nums[right];
                if (sum3 > 0)
                {
                    right -= 1;
                }
                else if(sum3 < 0)
                {
                    left += 1;
                }
                else
                {
                    result.Add(new List<int> {x, nums[left], nums[right]});
                    left += 1;
                    while (nums[left] == nums[left - 1] && left < right)
                    {
                        left += 1;
                    }
                }
            }
        }
        
        return result;
}






