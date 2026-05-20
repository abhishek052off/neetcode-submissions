public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        
        var cars = position
                .Zip(speed, (p, s) => (Position: p, Speed: s))
                .OrderBy(x => x.Position)
                .ToList();

        // (position , speed) in + order 

        var st = new Stack<decimal>();

        foreach(var car in cars){
            decimal t2r  = (decimal)(target - car.Position) / car.Speed; 

            while(st.Count != 0 &&  t2r >= st.Peek()){
                st.Pop();
            }

            st.Push(t2r);
        }


        return st.Count;
         
    }
}
