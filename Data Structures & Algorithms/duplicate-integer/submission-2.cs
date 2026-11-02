public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> hashSetArray = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (hashSetArray.Contains(nums[i]))
            {
                return true;
            }
            else
            {
                hashSetArray.Add(nums[i]);
            }
        }
        return false;
    }
}