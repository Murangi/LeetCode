public class Solution {
    public int LongestConsecutive(int[] nums) {
       
       int Length = nums.Length;
       int LongestConsecutiveElements = 1;

       //Create List and add add nums array to list.
       List<int> ListNums = new List<int>(nums);
       List<int> gaps = new List<int>();
       
       //We are now going to sort the list.
       ListNums.Sort();
       //Overwriting with the sorted list.
       nums = ListNums.ToArray();
       if(Length == 0)
       {
         return 0;
       }
       //Finding the longest consecutive elements
       for(int i = 1 ; i < Length; i++)
       {  
          if(nums[i] == nums[i -1])
          {
            continue;
          }
          if((nums[i] - nums[i-1]) == 1)
          {
            LongestConsecutiveElements++;

          }
          else
          {
            gaps.Add(LongestConsecutiveElements);
            LongestConsecutiveElements = 1;
          }
       }
       gaps.Add(LongestConsecutiveElements);
       gaps.Sort();

       return gaps[gaps.Count() - 1];
       

    }
}