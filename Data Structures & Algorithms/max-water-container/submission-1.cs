public class Solution {
    public int MaxArea(int[] heights) {
        var left = 0;
        var right = heights.Length - 1;
        var max = 0;
        while (left < right) {
            var cur = Math.Min(heights[left], heights[right]) * (right - left);
            if (cur > max) {
                max = cur;
            }
            if (heights[left] < heights[right]) {
                left++;
            } else {
                right--;
            }
        }
        return max;
    }
}
