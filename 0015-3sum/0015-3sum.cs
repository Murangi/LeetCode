public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        
        var res = new List<IList<int>>();
        Array.Sort(nums); // Sort the array

        for (int i = 0; i < nums.Length; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
                continue; // Skip duplicate values for `a`

            int l = i + 1, r = nums.Length - 1;

            while (l < r)
            {
                int threeSum = nums[i] + nums[l] + nums[r];
                if (threeSum > 0)
                {
                    r--; // Move the right pointer leftward
                }
                else if (threeSum < 0)
                {
                    l++; // Move the left pointer rightward
                }
                else
                {
                    // Add the triplet to the result list
                    res.Add(new List<int> { nums[i], nums[l], nums[r] });
                    l++;
                    while (l < r && nums[l] == nums[l - 1])
                        l++; // Skip duplicate values for the left pointer
                }
            }
        }

        return res;
        
    }
}