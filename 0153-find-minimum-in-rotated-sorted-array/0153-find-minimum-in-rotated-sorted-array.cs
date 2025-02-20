public class Solution {
    public int FindMin(int[] nums) {
        int Right = nums.Length - 1;
        int Left = 0;

        // If the array is not rotated, return the first element
        if (nums[Right] > nums[Left])
        {
            return nums[Left];
        }

        while (Left < Right)
        {
            int Middle = (Left + Right) / 2;

            // Check if Middle is the pivot point
            if (nums[Middle] > nums[Middle + 1])
            {
                return nums[Middle + 1];
            }

            if (nums[Middle] < nums[Middle - 1])
            {
                return nums[Middle];
            }

            // Adjust search space
            if (nums[Middle] > nums[Right])
            {
                Left = Middle + 1;
            }
            else
            {
                Right = Middle;
            }
        }

        return nums[Left]; // The minimum value
    }

    
}