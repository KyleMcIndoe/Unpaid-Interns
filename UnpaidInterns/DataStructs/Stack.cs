public class stack {
    List<int> elements = new List<int>();

    public stack() {

    }

    public void push(int x) {
        elements.Add(x);
    }

    public int pop() {
        int x = elements[elements.Count - 1];
        elements.RemoveAt(elements.Count - 1);
        return x;
    }

    public int count() {
        return elements.Count;
    }

    public int getTop() {
        return elements[elements.Count - 1];
    }
}