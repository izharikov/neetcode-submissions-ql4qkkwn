public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var len = nums.Length;
        var preffix = new int[len + 2];
        var suffix = new int[len + 2];
        preffix[0] = 1;
        suffix[len + 1] = 1;
        for (var i = 1; i < len + 1; i++){
            preffix[i] = preffix[i - 1] * nums[i - 1];
            suffix[len + 1 - i] = suffix[len + 2 - i] * nums[len - i];
        }
        var res = new int[len];
        for (var i = 0; i < len; i++){
            res[i] = preffix[i] * suffix[i + 2];
        }
        return res;
    }
}
