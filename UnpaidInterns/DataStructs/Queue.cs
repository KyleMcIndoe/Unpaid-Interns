class queue<T> {
    List<T> elements = new List<T>();

    public queue() {

    }

    public void push(T x) {
        elements.Add(x);
    }

    public int count() {
        return elements.Count;
    }

    public T front() {
        return elements[0];
    }

    public T back() {
        return elements[elements.Count - 1];
    }

    public T pop() {
        T x = elements[0];
        elements.RemoveAt(0);
        return x;
    }
}