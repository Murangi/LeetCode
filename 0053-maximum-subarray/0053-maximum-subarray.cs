public class Solution {
    public int MaxSubArray(int[] nums) {

        int maxSub = nums[0];
        int curSum = 0;

        foreach (int n in nums)
        {
            if (curSum < 0)
            {
                curSum = 0;
            }
            curSum += n;
            maxSub = Math.Max(maxSub, curSum);
        }

        return maxSub;

    }
}