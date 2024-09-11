using System.Configuration.Assemblies;

public class treeNode{
    public int val;
    public treeNode? left;
    public treeNode? right;

    public treeNode(int x){
        this.val = x;
        this.left = null;
        this.right = null;
    }

    public treeNode(int x, treeNode l, treeNode r) {
        this.val = x;
        this.left = l;
        this.right = r;
    }
}

public class tree {
    public treeNode root;

    public tree(int x) {
        this.root = new treeNode(x);
    }

    public int count() {
        int c = 0;
        void check(treeNode x) {
            c++;
            if(x.left != null) check(x.left);
            if(x.right != null) check(x.right);
        }

        check(this.root);

        return c;
    }

    public int[] toArray() {
        int[] arr = new int[this.count()];
        int i = 0;
        void check(treeNode x) {
            arr[i] = x.val;
            i++;
            if(x.left != null) check(x.left);
            if(x.right != null) check(x.right);
        }

        check(this.root);

        return arr;
    }

    public List<treeNode> findLeaves() {
        List<treeNode> ans = new List<treeNode>();
        
        void check(treeNode x) {
            if(x.left == null && x.right == null) ans.Add(x);
            if(x.left != null) check(x.left);
            if(x.right != null) check(x.right);
        }

        return ans;
    }
}