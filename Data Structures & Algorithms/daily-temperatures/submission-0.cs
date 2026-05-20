public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var st = new Stack<int>();
        var result = new int[temperatures.Length];

        for(int i = 0 ;i<temperatures.Length ; i++){

            int current = temperatures[i];

            while(st.Count != 0 && temperatures[st.Peek()] < current ){

                int val = st.Pop();
                int distance = i-val;
                result[val] = distance;
                
            }

            st.Push(i);
        }

        return result;
    }
}
