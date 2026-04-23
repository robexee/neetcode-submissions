public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for(int i = 0; i < nums.Length; i++)
        {
            for(int j = i + 1; j< nums.Length; j++)
            {
                int number = target - nums[i];
                if(number == nums[j] && j != i)
                {
                    return new int[] {i,j};
                }
            }
        }
        return new int[0];
    }
}
