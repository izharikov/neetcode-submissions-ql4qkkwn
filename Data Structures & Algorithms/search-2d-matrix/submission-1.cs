public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        var rows = matrix.Length;
        var cols = matrix[0].Length;
        var left = 0;
        var right = rows * cols - 1;
        while (left < right) {
            var middle = (left + right) / 2;
            var curRow = middle / cols;
            var curCol = middle % cols;
            var item = matrix[curRow][curCol];
            if (item == target) {
                return true;
            } else if (item < target) {
                left = middle + 1;
            } else if (item > target) {
                right = middle - 1;
            }
        }

        var r = left / cols;
        var c = left % cols;
        if (r > -1 && c > -1 && target == matrix[r][c]) {
            return true;
        }

        r = right / cols;
        c = right % cols;

        if (r > -1 && c > -1 && target == matrix[r][c]) {
            return true;
        }

        return false;
    }
}

// public class Solution {
//     public int Search(int[] nums, int target) {
//         if (nums.Length == 1) {
//             return nums[0] == target ? 0 : -1;
//         }
//         var left = 0;
//         var right = nums.Length - 1;
//         while (left < right) {
//             var middle = (left + right) / 2;
//             if (nums[middle] == target) {
//                 return middle;
//             } else if (nums[middle] < target) {
//                 left = middle + 1;
//             } else if (nums[middle] > target) {
//                 right = middle - 1;
//             }
//         }
//         if (right > -1 && target == nums[right]) {
//             return right;
//         }
//         if (left > -1 && target == nums[left]) {
//             return left;
//         }
//         return -1;
//     }
// }
