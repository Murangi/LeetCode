public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        int[] TargetSum = new int[2]; 
        for(int i = 0; i < nums.Length -1;i++)
        {
            for(int j = i+1; j < nums.Length;j++)
            {
                if((nums[i] + nums[j]) == target)
                {
                    TargetSum[0] = i;
                    TargetSum[1] = j;

                    return TargetSum;
                }
            }
        }

        return TargetSum;
    }
}



