public class Solution {
    public int MaxArea(int[] heights) {
        var left = 0;
        var right = heights.Length - 1;
        var max = Math.Min(heights[left], heights[right]) * (right - left);
        while (left < right) {
            if (heights[left] < heights[right]) {
                while (heights[left] >= heights[++left] && left < right){
                    // left++;
                }
            } else {
                while (heights[right] >= heights[--right] && left < right){
                    // right--;
                }
            }
            var cur = Math.Min(heights[left], heights[right]) * (right - left);
            if (cur > max) {
                max = cur;
            }
        }
        return max;
    }
}
