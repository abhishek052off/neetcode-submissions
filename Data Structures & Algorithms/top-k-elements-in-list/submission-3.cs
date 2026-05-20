public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        var freq = new Dictionary<int , int>();

        foreach(int num in nums){
            freq[num] = freq.GetValueOrDefault(num , 0)+1;
        }

        var pq = new PriorityQueue<int, int>();

        foreach(var item in freq.Keys){
            pq.Enqueue(item,freq[item]);
            if(pq.Count > k) pq.Dequeue();
        }

        var result = new int[pq.Count];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = pq.Dequeue();
        }
        return result;

    }
}
