public class Solution {
    public int LengthOfLongestSubstring(string s) {
        
        int iLength = s.Length;
        char[] MySubstring = s.ToCharArray();
        char[] Window = new char[iLength];
        Window[0] = MySubstring[0];
        int LongestSubstring = 1;
        
        if(iLength == 0)
        {
            return 0;
        }
        else if (iLength == 1)
        {
            return 1;
        }
        else
        {
            for(int i = 0; i < iLength; i++)
            {
               if(!Window.Contains(MySubstring[i]))
               {
                 Window[LongestSubstring] = MySubstring[i];
                 LongestSubstring++;
               }

            }
        }

        return LongestSubstring;
    }
}