public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

        Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>();

        for (int index = 0; index < strs.Length; index++)
        {
            int[] Map = new int[26];

            string key = string.Empty;
            
            for (int i = 0; i < strs[index].Length; i++)
            {
                Map[strs[index][i] - 'a']++;
            }

            for (int j = 0; j < Map.Length; j++)
            {
                key += Map[j] + "#";
            }

            if (groups.ContainsKey(key))
            {
                groups[key].Add(strs[index]);
            }
            else 
            {
                groups.Add(key, new List<string> { strs[index] });
            }
        }

        List<List<string>> results = new List<List<string>>();

        foreach (var group in groups.Values)
        {
            results.Add(group);
        }
        return results;
    }

}
