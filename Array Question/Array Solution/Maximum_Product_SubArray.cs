using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Question.Array_Solution
{
    public class Maximum_Product_SubArray
    {
        public static void Max_Product_SubArray(int[] nums)
        { 
            if (nums.Length == 1) return;

            int ans = nums[0];
            int max = ans;
            int min = ans;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < 0)
                {
                    (max, min) = (min, max);
                }

                max = Math.Max(nums[i], max * nums[i]);
                min = Math.Min(nums[i], min * nums[i]);
                ans = Math.Max(ans, max);
            }
            Console.WriteLine("Maximum product Subarray: " + ans);
        }
    }
}
