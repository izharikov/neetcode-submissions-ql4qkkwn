public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length <= 1){
            return nums.Length;
        }
        var lengths = new Dictionary<int, int>();

        var max = 1;
        for (var i = 0; i < nums.Length; i++){
            var num = nums[i];
            if (lengths.ContainsKey(num)){
                continue;
            }
            lengths.TryGetValue(num - 1, out var left);
            lengths.TryGetValue(num + 1, out var right);
            var len = left + right + 1;
            lengths[num] = len;
            if (left > 0) {
                lengths[num - left] = len;
            }
            if (right > 0){
                lengths[num + right] = len;
            }
            max = Math.Max(len, max);
        }
        return max;
    }
}
