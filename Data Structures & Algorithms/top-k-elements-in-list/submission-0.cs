public class Solution {
    public int[] TopKFrequent(int[] nums, int k) => nums.GroupBy(x => x)
           .OrderByDescending(g => g.Count())
           .Take(k)
           .Select(g => g.Key)
           .ToArray();
}
