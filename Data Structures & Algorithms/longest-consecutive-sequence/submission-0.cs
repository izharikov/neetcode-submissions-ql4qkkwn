public class Solution {
    public int LongestConsecutive(int[] nums) {
        var unique = new HashSet<int>(nums);
        var max = 1;
        for (var i = 0; i < nums.Length; i++){
            var start = !unique.Contains(nums[i] - 1);
            if (start) {
                var count = 1;
                var t = nums[i] + 1;
                while (unique.Contains(t++)) {
                    count++;
                }
                if (max < count) {
                    max = count;
                }
            }
        }
        return max;
    }
}
