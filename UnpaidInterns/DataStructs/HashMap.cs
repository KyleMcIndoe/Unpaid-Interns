class hashMap<t> { // map strings to a data type t
    public List<string> keys = new List<string>();

    public t?[] values = new t[25500];


    public hashMap() {

    }

    public t? getVal(string key){
        int index = funcs.hashFunction(key);
        return this.values[index];
    }

    public void add(string key, t value) {
        this.keys.Add(key);
        int i = funcs.hashFunction(key.ToString());
        this.values[i] = value;
    }

    public void remove(string key) {
        this.values[funcs.hashFunction(key)] = default(t);
        keys.Remove(key);
    }
}