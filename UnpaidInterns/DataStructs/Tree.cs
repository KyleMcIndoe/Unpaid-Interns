using System.Configuration.Assemblies;

public class treeNode<t>{
    public t val;
    public treeNode<t>? left;
    public treeNode<t>? right;

    public treeNode(t x){
        this.val = x;
        this.left = null;
        this.right = null;
    }

    public treeNode(t x, treeNode<t> l, treeNode<t> r) {
        this.val = x;
        this.left = l;
        this.right = r;
    }
}

public class tree<t> {
    public treeNode<t> root;

    public tree(t x) {
        this.root = new treeNode<t>(x);
    }

    public int count() {
        int c = 0;
        void check(treeNode<t> x) {
            c++;
            if(x.left != null) check(x.left);
            if(x.right != null) check(x.right);
        }

        check(this.root);

        return c;
    }

    public t[] toArray() {
        t[] arr = new t[this.count()];
        int i = 0;
        void check(treeNode<t> x) {
            arr[i] = x.val;
            i++;
            if(x.left != null) check(x.left);
            if(x.right != null) check(x.right);
        }

        check(this.root);

        return arr;
    }

    public List<treeNode<t>> findLeaves() {
        List<treeNode<t>> ans = new List<treeNode<t>>();
        
        void check(treeNode<t> x) {
            if(x.left == null && x.right == null) ans.Add(x);
            if(x.left != null) check(x.left);
            if(x.right != null) check(x.right);
        }

        return ans;
    }
}