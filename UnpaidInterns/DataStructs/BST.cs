class bstNode {
    int val;
    bstNode? left;
    bstNode? right;

    public bstNode(int x) {
        this.val = x;
    }

    public bstNode(int x, bstNode l, bstNode r) {
        this.val = x;
        this.left = l;
        this.right = r;
    }
}