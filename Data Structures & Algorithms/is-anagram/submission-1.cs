public class Solution {
    public bool IsAnagram(string s, string t) {
        bool[] folosit= new bool[t.Length];
        int nr = 0;
        if(s.Length != t.Length)
        {
            return false;
        }
        for(int i = 0; i< s.Length; i++)
        {
            for(int j = 0; j< t.Length; j++)
            {
               if(s[i]==t[j] && folosit[j] == false)
               {
                folosit[j] = true;
                nr++;
                break;
               }
            }
        }
        if(nr == s.Length)
        { 
            return true;
        }
        else
        {
            return false;
        }
    }
}
