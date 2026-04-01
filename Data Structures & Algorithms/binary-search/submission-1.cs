public class Solution {
    public int Search(int[] nums, int target) {
        if (nums.Length == 1) {
            return nums[0] == target ? 0 : -1;
        }
        var left = 0;
        var right = nums.Length - 1;
        while (left < right) {
            var middle = (left + right) / 2;
            if (nums[middle] == target) {
                return middle;
            } else if (nums[middle] < target) {
                left = middle + 1;
            } else if (nums[middle] > target) {
                right = middle - 1;
            }
        }
        if (right > -1 && target == nums[right]) {
            return right;
        }
        if (left > -1 && target == nums[left]) {
            return left;
        }
        return -1;
    }
}
