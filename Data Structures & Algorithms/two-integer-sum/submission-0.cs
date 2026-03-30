public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int, int>();
        for (var i = 0; i < nums[i]; i++) {
            var second = target - nums[i];
            if (dict.TryGetValue(second, out var index)){
                return new int[] {index, i};
            }
            dict[nums[i]] = i;
        }

        return new int[0];
    }
}
