public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var result = new List<int>() { nums[1], nums[0]};
        if (nums.Length == 2){
            return result.ToArray();
        }

        var product = nums[0] * nums[1];
        for (var i = 2; i < nums.Length; i++) {
            for (var j = 0; j < result.Count; j++) {
                result[j] *= nums[i];
            }
            result.Add(product);
            product *= nums[i];
        }
        return result.ToArray();
    }
}
