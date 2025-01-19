public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // Dictionary to store the number as the key and its index as the value
        Dictionary<int, int> MyDictionary = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            int Difference = target - nums[i];

            // Check if the difference exists as a key in the dictionary
            if (MyDictionary.ContainsKey(Difference)) {
                // If found, return the indices of the two numbers
                return new int[] { MyDictionary[Difference], i };
            }

            // If not found, add the current number and its index to the dictionary
            MyDictionary[nums[i]] = i;
        }

        // Return an empty array or throw an exception if no solution exists
        throw new ArgumentException("No two sum solution found.");
    }
}
