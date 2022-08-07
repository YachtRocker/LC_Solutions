using System;

int[] height = {1,8,6,2,5,4,8,3,7};
int res = MaxArea(height);  
Console.WriteLine(res);

public class lc11 {
        public int MaxArea(int[] height) {
            int result = 0;
            int left = 0;
            int right = height.Length - 1;
            int area = 0;

            while (left < right)
            {
                area = (right - left) * Math.Min(height[left], height[right]);
                result = Math.Max(result, area);

                if (height[left] < height[right])
                {
                    left += 1;
                }            
                else
                {
                    right -= 1;
                }
            }

            return result;
        }       
}   



