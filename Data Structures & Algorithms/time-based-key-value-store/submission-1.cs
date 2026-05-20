public class TimeMap {

    private readonly Dictionary<string, List<(int timestamp, string value)>> _store;

    public TimeMap() {
        _store = new Dictionary<string , List<(int timestamp, string value)> >();
    }
    
    public void Set(string key, string value, int timestamp) {

        if(_store.ContainsKey(key)){

            var list = _store[key];
            list.Add((timestamp , value));
            return;
        }

        _store[key] = new List<(int , string)>{ (timestamp , value )};

    }
    
    public string Get(string key, int timestamp) {
        //This is a boundry finding problem 
        var list =   _store.ContainsKey(key) ? _store[key] : new ();

        int l = 0 ;
        int h = list.Count - 1;

        if(h == -1) return string.Empty;

        
        while(l <= h)
        {
            int mid = (l+h)/2;
            Console.WriteLine($"Low {l} ,high {h} , mid {mid}");

            if( list[mid].timestamp  <= timestamp ){
                l = mid+1;
            }
            else{
                h = mid-1;
            }
        }

        return h >= 0 && h<list.Count ?  list[h].value : string.Empty;

    }
}
