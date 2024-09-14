public class bstNode {
    public int val;
    public bstNode? left;
    public bstNode? right;

    public bstNode(int x) {
        this.val = x;
    }

    public bstNode(int x, bstNode l, bstNode r) {
        this.val = x;
        this.left = l;
        this.right = r;
    }
}

public class bst {
    bstNode root;

    public bst(int x) {
        this.root = new bstNode(x);
    }

    public bst(bstNode x) {
        this.root = x;
    }

    public void add(int x) {
        void check(int x, bstNode node) { // this solution is disgusting
            if(x >= node.val ) {
                if(node.right != null) {
                    check(x, node.right);
                } else {
                    node.right = new bstNode(x);
                    return;
                }
            }
            if(x < node.val) {
                if(node.left != null) {
                    check(x, node.left);
                } else {
                    node.left = new bstNode(x);
                    return;
                }
            }
        }

        check(x, this.root);
    }
}