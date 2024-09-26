public class listNode<T> {
    public T val;
    public listNode<T>? next;

    public listNode(T x) {
        this.val = x;
        this.next = null;
    }

    public listNode(T x, listNode<T> n) {
        this.val = x;
        this.next = n;
    }
}

public class linkedList<T> {
    public listNode<T> head;

    public linkedList(T x) {
        this.head = new listNode<T>(x);
    }

    public listNode<T> this[int index] {
        get {
            listNode<T>? n = this.head;
            for(int i = 0; i <= index && n != null; i++) {
                if(i == index) return n;
                n = n.next;
            }
            throw new Exception("Node not found in linked list");
        }
    }

    public T? getVal(int index) {
        listNode<T>? n = this.head;
        for(int i = 0; i <= index && n != null; i++) {
            if(i == index) return n.val;
            n = n.next;
        }
        return default(T);
    }

    public listNode<T>? getNode(int index) {
        listNode<T>? n = this.head;
        for(int i = 0; i <= index && n != null; i++) {
            if(i == index) return n;
            n = n.next;
        }
        return null;
    }

    public int count() {
        int l = 0;
        listNode<T>? n = this.head;
        while(n != null) {
            l++;
            n = n.next;
        }
        return l;
    }
    public listNode<T> getLast() {
        listNode<T> n = this.head;
        while(n.next != null)  n = n.next;
        return n;
    }
    public void add(T x) {
        getLast().next = new listNode<T>(x);
    }

    public void add(T x, int index) {
        if(index >= this.count()) {
            this.add(x);
            return;
        }

        listNode<T>? n = this.head;
        for(int i = 0; i < index && n.next != null; i++) {
            if(i == index - 1) {
                listNode<T> a = n.next;
                n.next = new listNode<T>(x, a);
            }
            n = n.next;
        }
    }

    public void remove(int index) {

        listNode<T>? n = this.head;
        for(int i = 0; i <= index && n != null; i++) {
            if(i == index - 1 && n.next != null) {
                if(n.next.next == null) {
                    n.next = null;
                    return;
                }
                listNode<T> toR = n.next;
                n.next = toR.next;
                toR.next = null;
            }
        }
    }

    public T[] toArray() {
        T[] ans = new T[this.count()];
        listNode<T>? n = this.head;

        for(int i = 0; n != null; i++) {
            ans[i] = n.val;
            n = n.next;
        }

        return ans;
    }

}