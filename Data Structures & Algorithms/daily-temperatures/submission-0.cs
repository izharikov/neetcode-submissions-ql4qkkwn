public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var results = new int[temperatures.Length];
        var indexes = new Stack<int>();
        indexes.Push(0);
        for (var i = 1; i < temperatures.Length; i++) {
            var cur = temperatures[i];
            while(indexes.Count > 0 && temperatures[indexes.Peek()] < cur) {
                var index = indexes.Pop();
                results[index] = i - index;
            }
            indexes.Push(i);
        }
        return results;
    }
}
