public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        var result = new List<List<int>>();
        var uniques = new HashSet<string>();
        // var targets = new HashSet<int>();
        for (var i = 0; i < nums.Length - 2; i++) {
            var target = - nums[i];
            var left = i + 1;
            var right = nums.Length - 1;
            while (left < right) {
                var cur = nums[left] + nums[right];
                if (cur == target) {
                    // TODO: check duplicates
                    var key = $"{nums[i]}_{nums[left]}";
                    if (uniques.Add(key)){
                    // if(targets.Add(target)) {
                        result.Add(new List<int>(new [] {nums[i], nums[left], nums[right]}));
                    }
                    left++;
                } else if (cur < target) {
                    left++;
                } else {
                    right--;
                }

            }
        }
        return result;
    }
}
