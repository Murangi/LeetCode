public class Solution {
    public int LengthOfLongestSubstring(string s) {
        
        int iLength = s.Length;
        char[] MySubstring = s.ToCharArray();
        //char[] Window = new char[iLength];
        List<char> Window = new List<char>();
        HashSet<char> NoDuplicates = new HashSet<char>();

        int LongestSubstring = 0;
        
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
            //    if(!Window.Contains(MySubstring[i]))
            //    {
            //      //Window[LongestSubstring] = MySubstring[i];
            //      Window.Add(MySubstring[i]);
            //      LongestSubstring++;
            //    }
                
                NoDuplicates = Window.ToHashSet();
                
                if(!Window.Contains(MySubstring[i]) && Window.Count() == NoDuplicates.Count())
                {
                    Window.Add(MySubstring[i]);
                    LongestSubstring++;
                }
                else
                {   
                    Window.Add(MySubstring[i]);
                    Window.RemoveAt(0);
                } 

            }
        }

        return LongestSubstring;
    }
}