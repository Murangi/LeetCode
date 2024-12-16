public class Solution {
    public bool ContainsDuplicate(int[] nums) {
      for(int i = 0; i < nums.Length -1; i++)
      {
        for(int j = i+1; j < nums.Length; j++)
        {
           
           //We are going to compare a
            if(nums[i] == nums[j])
            {
                return true;
            }
        }
      }

      return false;  
    }
}