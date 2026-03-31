public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
        {
            return false;
        }

        int[] AlphaMap = new int[26];
        for (int i = 0; i < s.Length; i++)
        {
            int a = s[i] - 'a';
            AlphaMap[a]++;
        }

        for (int j = 0; j < t.Length; j++)
        {
            int b = t[j] - 'a';
            AlphaMap[b]--;
        }

        for (int k = 0; k < AlphaMap.Length; k++)
        {
            if (AlphaMap[k] != 0)
            {
                return false;
            }
        }
        return true;

    }
}
