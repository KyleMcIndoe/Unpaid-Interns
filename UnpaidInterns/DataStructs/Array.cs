public static class ArrFuncs {
    public static T[] reverse<T>(T[] arr) {
        T[] result = new T[arr.Length];

        for(int i = 0; i < arr.Length; i++) {
            result[result.Length - 1 - i] = arr[i];
        }

        return result;
    }
}