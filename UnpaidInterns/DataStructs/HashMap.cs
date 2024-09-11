class hashMap {
    public List<string> keys = new List<string>();

    public string[] values = new string[25500];


    public hashMap() {

    }
    
    public string getVal(string key){
        int index = funcs.hashFunction(key);
        return this.values[index];
    }

    public void add(string key, string value) {
        this.keys.Add(key);
        int i = funcs.hashFunction(key);
        this.values[i] = value;
    }

    public void remove(string key) {
        this.values[funcs.hashFunction(key)] = "";
        keys.Remove(key);
    }

    public string[][] getKeyValuePairs() {
        string[][] pairs = new string[this.keys.Count][];

        for(int i = 0; i < pairs.Length; i++) {
            pairs[i] = new string[2];
            pairs[i][0] = this.keys[i];
            pairs[i][1] = getVal(this.keys[i]);
        }

        return pairs;
    }
}