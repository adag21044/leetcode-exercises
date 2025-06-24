public class Solution 
{
    public string LongestCommonPrefix(string[] strs) //[element][char]
    {
        string common = string.Empty;
        string first = strs[0];
        int minLen = MinLength(strs);
        
        for (int j = 0; j < minLen; j++)
        {
            char current = first[j];

            for (int i = 1; i < strs.Length; i++)
            {
                if (strs[i][j] != current)
                    return common;
            }

            common += current;
        }

        return common;

          
    }

    public int MinLength(string[] strs)
    {
        int min = strs[0].Length;

        for(int i = 1; i < strs.Length; i++)
        {
            if(min > strs[i].Length)
            {
                min = strs[i].Length;
            }
        }

        return min;
    }
}
