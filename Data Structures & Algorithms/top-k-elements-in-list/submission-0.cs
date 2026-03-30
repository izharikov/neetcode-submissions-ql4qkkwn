public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dict = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++) {
            if (dict.TryGetValue(nums[i], out var v)) {
                dict[nums[i]] = v + 1;
            } else {
                dict[nums[i]] = 1;
            }
        }

        var kvs = dict.ToList();
        var ordered = kvs.OrderByDescending(x => x.Value);
        return ordered.Take(k).Select(x => x.Key).ToArray();
    }
}
