using System;

namespace MyMath
{
    public class Operations
    {
        public static int Max(List<int> nums)
        {
            if(nums == null)
            {
                return 0;
            }
            else
            {
                int max = nums[0];
                foreach(int i in nums)
                if (i > max)
                    max = i;
                return max;
            }
        }
    }
}
