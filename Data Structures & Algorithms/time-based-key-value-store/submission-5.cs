public class TimeMap {

    private readonly Dictionary<string, List<(int timestamp, string value)>> _store;

    public TimeMap() {
        _store = new Dictionary<string , List<(int timestamp, string value)> >();
    }
    
    public void Set(string key, string value, int timestamp) {
        _store.TryAdd(key , new());
        _store[key].Add((timestamp , value));
    }
    
    public string Get(string key, int timestamp) {
       

        if (!_store.TryGetValue(key, out var list))
            return string.Empty;

        int l = 0 ;
        int h = list.Count - 1;

        

        
        while(l <= h)
        {
            int mid = (l+h)/2;
            Console.WriteLine($"Low {l} ,high {h} , mid {mid}");

            if(list[mid].timestamp == timestamp) return list[mid].value;

            if( list[mid].timestamp  < timestamp ){
                l = mid+1;
            }
            else{
                h = mid-1;
            }
        }

        return h >= 0 && h<list.Count ?  list[h].value : string.Empty;

    }
}
