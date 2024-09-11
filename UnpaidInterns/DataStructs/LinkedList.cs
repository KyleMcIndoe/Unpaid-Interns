public class listNode {
    public int val;
    public listNode? next;

    public listNode(int x) {
        this.val = x;
        this.next = null;
    }

    public listNode(int x, listNode n) {
        this.val = x;
        this.next = n;
    }
}

public class linkedList {
    public listNode head;

    public linkedList(int x) {
        this.head = new listNode(x);
    }

    public int? getVal(int index) {
        listNode? n = this.head;
        for(int i = 0; i <= index && n != null; i++) {
            if(i == index) return n.val;
            n = n.next;
        }
        return null;
    }

    public listNode? getNode(int index) {
        listNode? n = this.head;
        for(int i = 0; i <= index && n != null; i++) {
            if(i == index) return n;
            n = n.next;
        }
        return null;
    }

    public int count() {
        int l = 0;
        listNode? n = this.head;
        while(n != null) {
            l++;
            n = n.next;
        }
        return l;
    }
    public listNode getLast() {
        listNode n = this.head;
        while(n.next != null)  n = n.next;
        return n;
    }
    public void add(int x) {
        getLast().next = new listNode(x);
    }

    public void add(int x, int index) {
        if(index >= this.count()) {
            this.add(x);
            return;
        }

        listNode? n = this.head;
        for(int i = 0; i < index && n.next != null; i++) {
            if(i == index - 1) {
                listNode a = n.next;
                n.next = new listNode(x, a);
            }
            n = n.next;
        }
    }

    public void remove(int index) {

        listNode? n = this.head;
        for(int i = 0; i <= index && n != null; i++) {
            if(i == index - 1 && n.next != null) {
                if(n.next.next == null) {
                    n.next = null;
                    return;
                }
                listNode toR = n.next;
                n.next = toR.next;
                toR.next = null;
            }
        }
    }

    public int[] toArray() {
        int[] ans = new int[this.count()];
        listNode? n = this.head;

        for(int i = 0; n != null; i++) {
            ans[i] = n.val;
            n = n.next;
        }

        return ans;
    }

}