public class Solution {
    public int Trap(int[] height) {
        if (height.Length < 3) {
            return 0;
        }
        var len = height.Length;
        var left = new int[len];
        var right = new int[len];
        for (var i = 1; i < len; i++) {
            left[i] = Math.Max(left[i - 1], height[i - 1]);
            right[len - 1 - i] = Math.Max(right[len - i], height[len - i]);
        }
        var sum = 0;
        for (var i = 0; i < len; i++) {
            sum += Math.Max(Math.Min(left[i], right[i]) - height[i], 0);
        }
        return sum;
    }
}
