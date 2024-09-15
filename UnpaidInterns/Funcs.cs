public static class funcs{
    public static int hashFunction(string s) {
        
        string stwo = s;
        if(s.Length > 100) {
        throw new Exception("hash key cannot have a length more than 100"); // so that the values array isnt 20 million indexes long
        }
        int total = 0;
        char[] charArr = s.ToCharArray();

        for(int i = 0; i < charArr.Length; i++) total += 11 * (int)charArr[i];

        return total;
        
    }

    public static int linearSearch(int[] ins, int val) {
        for(int i = 0; i < ins.Length; i++) {
            if(ins[i] == val) return i;
        }

        return -1;
    }

}