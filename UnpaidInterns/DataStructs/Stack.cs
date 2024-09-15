public class stack<t> {
    List<t> elements = new List<t>();

    public stack() {

    }

    public void push(t x) {
        elements.Add(x);
    }

    public t pop() {
        t x = elements[elements.Count - 1];
        elements.RemoveAt(elements.Count - 1);
        return x;
    }

    public int count() {
        return elements.Count;
    }

    public t getTop() {
        return elements[elements.Count - 1];
    }
}