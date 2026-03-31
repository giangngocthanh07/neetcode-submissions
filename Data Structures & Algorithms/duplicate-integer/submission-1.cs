public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> DistinctNums = new HashSet<int>();
        for(int i = 0; i < nums.Length; i++)
        {
            if (DistinctNums.Contains(nums[i]))
            {
                return true;
            }
            else
            {
                DistinctNums.Add(nums[i]);
            }
        }
        return false;
    }
}