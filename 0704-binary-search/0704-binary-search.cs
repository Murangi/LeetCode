public class Solution 
{
    public int Search(int[] nums, int target) 
    {
    
        int StartIndex = 0;
        int EndIndex = nums.Length -1;
        int Middle = (EndIndex - StartIndex)/2;
        int Found = -1;

        while(StartIndex <= EndIndex)
        {  
            Middle = StartIndex + (EndIndex - StartIndex)/2;
            if(target == nums[Middle])
            {
                return Middle;
                
            }
            else if(target < nums[Middle])
            {
                EndIndex = Middle -1;
                
            }
            else if (target > nums[Middle])
            {
                StartIndex = Middle + 1;
                     
            }
        
            
        }

        return Found;   
        
    }

}






    

